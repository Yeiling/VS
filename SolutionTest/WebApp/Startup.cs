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


            #region Asp.Net MVC AutoFac����ע��
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

            #region Asp.NetCore���캯��ע��

            services.AddScoped(typeof(HttpWebApiClientInterface<>), typeof(HttpWebApiClientArchieve<>));

            #region ��������ע��
            //services.ConfigureHttpApi<IMyWebApi>(c =>
            //{
            //    c.HttpHost = new Uri("http://localhost:9999/");
            //});
            //services.AddHttpApi<IMyWebApi>(); 
            #endregion

            #region ��������ע��
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
            //�汾����
            services.AddApiVersioning(opt =>
            {
                opt.ReportApiVersions = true; //��ѡ���ã�����Ϊtrueʱ��header���ذ汾��Ϣ
                opt.ApiVersionReader = new HeaderApiVersionReader("api-version");//new QueryStringApiVersionReader("version");
                //new HeaderApiVersionReader("api-version");  //Header�洢�汾�� https://localhost:44378/api/Teacher
                //new QueryStringApiVersionReader("version");  //Header�洢�汾�ţ���֧�ֲ�ѯ�ַ������� https://localhost:44378/api/Teacher?api-version=1

                opt.DefaultApiVersion = new ApiVersion(1, 0);//Ĭ�ϰ汾������δָ���汾�ľ�Ĭ����ִ�а汾1.0��API
                opt.AssumeDefaultVersionWhenUnspecified = true;//�Ƿ�����δָ���汾API��ָ��Ĭ�ϰ汾
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
                         Title = $"΢����ӿ� v{description.ApiVersion}",
                         Version = description.ApiVersion.ToString(),
                         Description = "������Ͻǰ汾�л�",
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

                //Ȩ��Token
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Description = "���������Bearer��Token������ ��Bearer {Token}�� ",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                });

                //����API XML�ĵ�
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
                app.UseDeveloperExceptionPage();  //����������
            }


            #region Map�ܵ���֧
            ////app.UseHttpsRedirection();
            ////app.UseRouting();
            ////app.UseAuthorization();
            ////appĬ�Ϲܵ���֧
            ////app.UseEndpoints(endpoints =>
            ////{
            ////    //MapControllers ����˶�����·�ɵĿ�����֧�֡�
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
            //                //MapControllers ����˶�����·�ɵĿ�����֧�֡�
            //                endpoints.MapControllers();
            //            });
            //        });

            //    });
            #endregion


            //Http--->Https
            app.UseHttpsRedirection();

            //��̬�ļ�

            //·�ɽ���
            app.UseRouting();

            //����

            //Ȩ��
            app.UseAuthorization();

            //�û��Զ����м��
            app.UseMiddleware<PollyMiddleWare>();

            //�ն˷���
            app.UseEndpoints(endpoints =>
            {
                //MapControllers ����˶�����·�ɵĿ�����֧�֡�
                endpoints.MapControllers();

                //MapControllerRoute ��ӿ������ĳ���·�ɡ�
                //endpoints.MapControllerRoute(
                //    name: "default",
                //    pattern: "{controller}/{action}/{id?}");

                ////MapAreaControllerRoute ���������Ĵ�ͳ·���������
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
                //c.OAuthAppName("������");
            });

        }
    }
}
