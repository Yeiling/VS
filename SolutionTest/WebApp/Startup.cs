using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using WebClient.AchieveFile;
using WebClient.InterfaceFile;
using WebClient.MiddleWare;

namespace WebApp
{
    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        public IConfiguration Configuration { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //Config config = services.Configure<Config>(Configuration.GetSection("Config"))
            //         .BuildServiceProvider().GetService<IOptions<Config>>().Value;


            #region Asp.Net MVC AutoFac属性注入
            //var builder = new ContainerBuilder();
            //builder.RegisterControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();

            //builder.Register(_ => new HttpApiFactory<IWebApi>()
            //    .ConfigureHttpApiConfig(c =>
            //    {
            //        c.HttpHost = new Uri("http://localhost:9999/");
            //        c.FormatOptions.DateTimeFormat = DateTimeFormats.ISO8601_WithMillisecond;
            //    }))
            //    .As<IHttpApiFactory<IWebApi>>()
            //    .SingleInstance();

            //builder.Register(c => c.Resolve<IHttpApiFactory<IWebApi>>().CreateHttpApi())
            //    .As<IWebApi>()
            //    .InstancePerRequest();

            //DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
            #endregion

            #region Asp.NetCore构造函数注入

            services.AddScoped(typeof(HttpWebApiClientInterface<>), typeof(HttpWebApiClientArchieve<>));

            #region 单个服务注入
            //services.ConfigureHttpApi<IMyWebApi>(c =>
            //{
            //    c.HttpHost = new Uri("http://localhost:9999/");
            //});
            //services.AddHttpApi<IMyWebApi>(); 
            #endregion

            #region 批量服务注入
            //var typelst = AppDomain.CurrentDomain.GetAssemblies()
            //                .SelectMany(a => a.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IHttpApi))));
            //if (typelst != null && typelst.Count() > 0)
            //{
            //    foreach (var apiType in typelst)
            //    {
            //        #region MyRegion
            //        //services.ConfigureHttpApi<IMyWebApi>(c =>
            //        //{
            //        //    c.HttpHost = new Uri("http://localhost:9999/");
            //        //});
            //        //services.AddHttpApi<IMyWebApi>(); 
            //        #endregion

            //        services.ConfigureHttpApi(apiType, oper =>
            //        {
            //            oper.HttpHost = new Uri("https://localhost:44378/");

            //        }).AddHttpApi(apiType);
            //        //.AddHttpMessageHandler(() =>
            //        //{
            //        //    return new ActionHandler();
            //        //});
            //    }
            //}

            #endregion

            #endregion

            #region Swagger          
            //版本控制
            services.AddApiVersioning(opt =>
            {
                opt.ReportApiVersions = true; //可选配置，设置为true时，header返回版本信息
                opt.ApiVersionReader = new HeaderApiVersionReader("api-version");//new QueryStringApiVersionReader("version");
                //new HeaderApiVersionReader("api-version");  //Header存储版本号 https://localhost:44378/api/Teacher
                //new QueryStringApiVersionReader("version");  //Header存储版本号，且支持查询字符串参数 https://localhost:44378/api/Teacher?api-version=1

                opt.DefaultApiVersion = new ApiVersion(1, 0);//默认版本，请求未指明版本的就默认认执行版本1.0的API
                opt.AssumeDefaultVersionWhenUnspecified = true;//是否启用未指明版本API，指向默认版本
            }).AddVersionedApiExplorer(option =>
            {
                option.GroupNameFormat = "'v'VVV";
                option.AssumeDefaultVersionWhenUnspecified = true;
            }).AddSwaggerGen(options =>
            {
                var Provider = services.BuildServiceProvider().GetRequiredService<IApiVersionDescriptionProvider>();
                foreach (var description in Provider.ApiVersionDescriptions)
                {
                    options.SwaggerDoc(description.GroupName,
                     new OpenApiInfo()
                     {
                         Title = $"微服务接口 v{description.ApiVersion}",
                         Version = description.ApiVersion.ToString(),
                         Description = "请点右上角版本切换",
                         Contact = new OpenApiContact() { Name = "DYFrame", Email = "1234567890@qq.com" }
                     }
                );

                    Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.xml").ToList()
                .ForEach(file =>
                {
                    options.IncludeXmlComments(file);
                });

                    options.OperationFilter<AddResponseHeadersFilter>();
                    options.OperationFilter<AppendAuthorizeToSummaryOperationFilter>();
                    options.OperationFilter<SecurityRequirementsOperationFilter>();
                }

                //权限Token
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Description = "请输入带有Bearer的Token，形如 “Bearer {Token}” ",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                });

                //生成API XML文档
                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                var xmlPath = Path.Combine(basePath, typeof(Startup).GetTypeInfo().Assembly.GetName().Name + ".xml");
                options.IncludeXmlComments(xmlPath);

            });
            #endregion

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        /// <param name="Provider"></param>
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider Provider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();  //开发环境下
            }


            #region Map管道分支
            ////app.UseHttpsRedirection();
            ////app.UseRouting();
            ////app.UseAuthorization();
            ////app默认管道分支
            ////app.UseEndpoints(endpoints =>
            ////{
            ////    //MapControllers 添加了对属性路由的控制器支持。
            ////    endpoints.MapControllers();
            ////});
            //app.Map("/app", applicationBuilder =>
            //    {
            //        //applicationBuilder.UseAuthorization();
            //        applicationBuilder.Map("/route1", c =>
            //        {
            //            c.UseHttpsRedirection();
            //            c.UseRouting();
            //            //c.UseAuthorization();
            //            c.UseEndpoints(endpoints =>
            //                {
            //                    endpoints.MapControllerRoute(
            //                        name: "default",
            //                        pattern: "{controller}/{action}/{id?}");
            //                });
            //        });

            //        applicationBuilder.Map("/route2", c =>
            //        {
            //            c.UseHttpsRedirection();
            //            c.UseRouting();
            //            //c.UseAuthorization();
            //            c.UseEndpoints(endpoints =>
            //            {
            //                //MapControllers 添加了对属性路由的控制器支持。
            //                endpoints.MapControllers();
            //            });
            //        });

            //    });
            #endregion


            //Http--->Https
            app.UseHttpsRedirection();

            //静态文件

            //路由解析
            app.UseRouting();

            //跨域

            //权限
            app.UseAuthorization();

            //用户自定义中间件
            app.UseMiddleware<PollyMiddleWare>();

            //终端服务
            app.UseEndpoints(endpoints =>
            {
                //MapControllers 添加了对属性路由的控制器支持。
                endpoints.MapControllers();

                //MapControllerRoute 添加控制器的常规路由。
                //endpoints.MapControllerRoute(
                //    name: "default",
                //    pattern: "{controller}/{action}/{id?}");

                ////MapAreaControllerRoute 将控制器的传统路由添加区域。
                //endpoints.MapAreaControllerRoute(
                //    name: "areas", "areas",
                //    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            });

            app.UseSwagger().UseSwaggerUI(c =>
            {
                foreach (var description in Provider.ApiVersionDescriptions)
                {
                    c.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToUpperInvariant());
                }

                //c.OAuthClientId("0000000");
                //c.OAuthAppName("体检服务");
            });

        }
    }
}
