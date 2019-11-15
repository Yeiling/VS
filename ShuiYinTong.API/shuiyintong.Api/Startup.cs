﻿using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using NLog.Web;
using shuiyintong.Api.Validate;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.IO;
using System.Reflection;

namespace shuiyintong.Api
{
    /// <summary>
    /// Startup类
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 配置属性
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        //IServiceProvider--- This method gets called by the runtime. Use this method to add services to the container.
        /// <summary>
        /// 配置服务
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //控制器注入时，替换服务
            services.Replace(ServiceDescriptor.Transient<IControllerActivator, ServiceBasedControllerActivator>());

            //WebAPI 全局顾虑器设置
            services.AddMvc(option =>
            {
                //Http添加请求参数验证---请求参数验证
                option.Filters.Add<ValidateModelFilter>();
                //Http请求异常处理验证---异常处理验证
                //option.Filters.Add<ValidateExceptionFilter>();
                //Http添加请求结果验证---请求结果验证
                //option.Filters.Add<ValidateResultFilter>();

            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // 注册Swagger服务
            services.AddSwaggerGen(c =>
            {
                //Swagger文档
                c.SwaggerDoc("v1", new Info { Title = "ShuiYinTong.WebApi", Version = "v1" });
                //Swagger Token过滤器
                c.OperationFilter<SwaggerOperationFilter>();

                //添加xml文件解析
                var xmlFile = Assembly.GetExecutingAssembly();
                var path = Path.GetDirectoryName(xmlFile.Location);
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                var fileList = directoryInfo.GetFiles("*.xml");
                if (fileList != null && fileList.Length > 0)
                {
                    foreach (var file in fileList)
                    {
                        var xmlPath = Path.Combine(file.ToString());
                        c.IncludeXmlComments(xmlPath, true);
                    }
                }

                //添加JWT（Bearer Token）认证
                //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                //.AddJwtBearer(options =>
                //{
                //    options.TokenValidationParameters = new TokenValidationParameters
                //    {
                //        ValidateIssuer = true,//是否验证Issuer
                //        ValidateAudience = true,//是否验证Audience
                //        ValidateLifetime = true,//是否验证失效时间
                //        ValidateIssuerSigningKey = true,//是否验证SecurityKey
                //        ValidAudience = AppSettings.SwaggerConfig.audience,//Audience
                //        ValidIssuer = AppSettings.SwaggerConfig.issuer,//Issuer，这两项和签发jwt的设置一致
                //        //拿到SecurityKey
                //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(AppSettings.SwaggerConfig.SecurityKey))
                //    };
                //});

                //Swagger中添加JWT认证功能如下
                //c.AddSecurityDefinition("Bearer", new ApiKeyScheme
                //{
                //    Description = "请输入带有Bearer的Token",
                //    Name = "Authorization",
                //    In = "header",
                //    Type = "apiKey"
                //});
                //c.AddSecurityRequirement(new Dictionary<string, IEnumerable<string>>
                //{
                //    { "Bearer",Enumerable.Empty<string>()},
                //});

            });

            //读取配置Json文件
            services.UseJsonConfig(Configuration);
            //Ajax跨域
            services.AddCors(options =>
            {
                options.AddPolicy("any", builder =>
                {
                    builder.AllowAnyOrigin() //允许任何来源的主机访问
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials();//指定处理cookie
                });
            });

            //------------------------------------AutoFac+AOP-------------------------------
            #region 写法1
            ////1：AutoFac+AOP合并注入
            //var Builder = new ContainerBuilder();
            ////2：AutoFac注册AOP LogInterceptor拦截器
            ////Builder.RegisterType<LogInterceptor>();

            ////3：注入泛型BaseService<>和接口IBaseService<>，并动态注入拦截器-->InterceptedBy(typeof(LogInterceptor)).EnableInterfaceInterceptors()
            //Builder.RegisterGeneric(typeof(BaseService<>)).As(typeof(IBaseService<>));
            ////.InterceptedBy(typeof(LogInterceptor)).EnableInterfaceInterceptors();

            ////注册所有以Service结尾的服务类
            ////（当前模块文件所在程序集中的所有类型注册为其实现的服务接口，注册模式为生命周期模式，所有的服务类都以Service结尾）
            ////Builder.RegisterAssemblyTypes(Assembly.Load("程序集名称"))
            ////    .Where(t => t.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();

            ////4：动态注入拦截器LogInterceptor---aop
            ////Builder.RegisterType<SPDBankController>()
            ////    .InterceptedBy(typeof(LogInterceptor))
            ////    .EnableClassInterceptors()
            ////    .PropertiesAutowired();

            ////注入程序集shuiyintong.Api
            ////Builder.RegisterAssemblyTypes(Assembly.Load("shuiyintong.Api")).PropertiesAutowired();
            ////属性注入当前程序集下的所有控制器PropertiesAutowired()和（控制器）拦截器EnableClassInterceptors()
            //var controllersTypesInAssembly = typeof(Startup).Assembly.GetExportedTypes()
            //.Where(type => typeof(ControllerBase).IsAssignableFrom(type)).ToArray();
            ////if (controllersTypesInAssembly != null && controllersTypesInAssembly.Length > 0)
            ////{
            ////    foreach (var controllersType in controllersTypesInAssembly)
            ////        Builder.RegisterType(controllersType).PropertiesAutowired() //属性注入
            ////            .InterceptedBy(typeof(LogInterceptor)).EnableClassInterceptors(); //启用类代理拦截器
            ////}
            //Builder.RegisterTypes(controllersTypesInAssembly)
            //    .PropertiesAutowired(); //属性注入
            //                            //.InterceptedBy(typeof(LogInterceptor)).EnableClassInterceptors(); //启用类代理拦截器

            ////---------------------------------------------AOP实例----------------------------------------------
            //#region AOP实例详情
            ////1：拦截器必须注册到Aufofac容器中，可以通过拦截器类型或者命名注入，这两种方式会让使用拦截器的方法有所不同 
            ////命名注入
            ////Builder.Register(c => new LogInterceptor()).Named<IInterceptor>("log-Interceptor");
            ////类型注入
            ////Builder.Register(c => new LogInterceptor());
            ////或者
            ////Builder.RegisterType<LogInterceptor>();

            ////2：启用拦截器
            ////启用类代理拦截
            ////方式一：给类型上加特性Attribute
            ////Builder.RegisterType<man>().EnableClassInterceptors();
            ////方式二：在注册类型到容器的时候动态注入拦截器(去掉类型上的特性Attribute)---动态注入---不需要在类型上加特性Attribute
            ////Builder.RegisterType<SPDBankController>().InterceptedBy(typeof(LogInterceptor)).EnableClassInterceptors();

            ////启用接口代理拦截
            ////方式一：给类型上加特性Attribute
            ////Builder.RegisterType<Man>().As<IPerson>().EnableInterfaceInterceptors();
            ////方式二：在注册类型到容器的时候动态注入拦截器(去掉类型上的特性Attribute)---动态注入---不需要在类型上加特性Attribute
            ////Builder.RegisterType<Man>().As<IPerson>().InterceptedBy(typeof(LogInterceptor)).EnableInterfaceInterceptors(); 
            //#endregion
            ////-----------------------------------------------AOP------------------------------------------------

            //Builder.Populate(services);
            //var container = Builder.Build();      
            //return new AutofacServiceProvider(container);
            #endregion

            #region 写法2
            var Builder = new ContainerBuilder();
            Builder.AutoFacIoc();

            Builder.Populate(services);
            var container = Builder.Build();
            return new AutofacServiceProvider(container);
            #endregion

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// <summary>
        /// 配置信息
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseHsts();

            app.UseHttpsRedirection();

            //Swagger JWT配置授权
            app.UseAuthentication();

            //NetCore WebAPI全局[异常]处理只能通过中间件来实现---区别于ASP.NET MVC全局过滤
            app.UseMiddleware<ErrorHandlingMiddleware>();

            //Nlog日志
            //使用NLog作为日志记录工具
            //loggingBuilder.AddNLog();
            //引入Nlog配置文件
            //webHostBuilder.UseNLog();

//            //使用NLog作为日志记录工具---添加方式1---也可以在Program中添加
//#pragma warning disable CS0618 // “ConfigureExtensions.AddNLog(ILoggerFactory)”已过时:“Instead use ILoggingBuilder.AddNLog() or IHostBuilder.UseNLog()”
//            loggerFactory.AddNLog();
//#pragma warning restore CS0618 // “ConfigureExtensions.AddNLog(ILoggerFactory)”已过时:“Instead use ILoggingBuilder.AddNLog() or IHostBuilder.UseNLog()”
//            //引入Nlog配置文件
//            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
//            var filePath = Path.Combine(path, "NLog.config");
//#pragma warning disable CS0618 // “AspNetExtensions.ConfigureNLog(IHostingEnvironment, string)”已过时:“Use UseNLog() on IHostBuilder / IWebHostBuilder, and NLog.Web.NLogBuilder.ConfigureNLog(). Or AddNLog() on ILoggingBuilder”
//            env.ConfigureNLog(filePath);
//#pragma warning restore CS0618 // “AspNetExtensions.ConfigureNLog(IHostingEnvironment, string)”已过时:“Use UseNLog() on IHostBuilder / IWebHostBuilder, and NLog.Web.NLogBuilder.ConfigureNLog(). Or AddNLog() on ILoggingBuilder”

            //添加Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ShuiYinTong.WebApi");
                c.RoutePrefix = string.Empty;
                //Swagger引入汉化
                //c.InjectJavascript($"/swagger.js");
            });

            //扩展路由
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "/{controller}/{action}/{id?}", new { controller = "Home", action = "Index" });
            });

        }
    }
}
