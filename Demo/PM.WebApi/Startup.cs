using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.IO;

namespace PM.WebApi
{
    /// <summary>
    /// Startup
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Startup
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        /// <summary>
        /// 配置Configuration
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// public void ConfigureServices(IServiceCollection services)
        /// </summary>
        /// <param name="services"></param>
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            #region 注册Swagger服务
            services.AddSwaggerGen(sgo =>
            {
                //MyWebApi
                sgo.SwaggerDoc("MyWebApi", new Info
                {
                    Version = "1.0",  //版本号
                    Title = "WebApi",  //主题
                    //Description = "WebApi框架",  //描述
                    //TermsOfService = null,
                    //Contact = new Contact() { Name = "CaiHui", Url = "www.baidu.com", Email = "123@qq.com" }
                });
                //添加读取注释服务  
                var basePath = PlatformServices.Default.Application.ApplicationBasePath;

                //读取控制器API
                var xmlPath = Path.Combine(basePath, "PM.WebApi.xml");
                sgo.IncludeXmlComments(xmlPath, true); //添加控制器层注释（true表示显示控制器注释）

                //读取实体类文件
                var entityXmlPath = Path.Combine(basePath, "PM.Entity.xml");
                sgo.IncludeXmlComments(entityXmlPath, true);

                var security = new Dictionary<string, IEnumerable<string>> { { "Bearer", new string[] { } }, };
                sgo.AddSecurityRequirement(security);//添加一个必须的全局安全信息，和AddSecurityDefinition方法指定的方案名称要一致，这里是Bearer。
                sgo.AddSecurityDefinition("Bearer", new ApiKeyScheme
                {
                    Description = "JWT授权(数据将在请求头中进行传输) 参数结构: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",    //jwt默认的参数名称
                    In = "header",   //jwt默认存放Authorization信息的位置(请求头中)
                    Type = "apiKey"
                });
            });
            #endregion

            #region 跨域处理 cors 服务
            //添加cors 服务 配置跨域处理           
            services.AddCors(options =>
            {
                //---正式环境下不要使用全开放处理---
                options.AddPolicy("Any", policy =>
                {
                    policy.AllowAnyOrigin() //允许任何来源的主机访问
                    .AllowAnyMethod() //允许任何方式
                    .AllowAnyHeader() //允许任何头
                    .AllowCredentials();//允许任意cookie
                });

                //测试环境下
                //支持多个域名端口 
                //string[] arry = { "http://127.0.0.1:1818", "http://localhost:1818", "http://localhost:8080", "http://localhost:8081", "http://localhost:8021" };
                //options.AddPolicy("LimitRequest", policy =>
                //{
                //    policy.WithOrigins(arry).AllowAnyHeader().AllowAnyMethod();
                //});
            });
            #endregion

            //#region AutoFac
            ////实例化 AutoFac  容器   
            //var builder = new ContainerBuilder();

            ////注册要通过反射创建的组件
            //builder.RegisterType<AdvertisementServices>().As<IAdvertisementServices>();

            ////将services填充到Autofac容器生成器中
            //builder.Populate(services);

            ////使用已进行的组件登记创建新容器
            //var ApplicationContainer = builder.Build();

            //#endregion
            //return new AutofacServiceProvider(ApplicationContainer);//第三方IOC接管 core内置DI容器
        }

        /// <summary>
        /// Configure
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //判断是否是环境变量
            if (env.IsDevelopment())
                //在开发环境中，使用异常页面会暴露错误的堆栈信息，所以不要放在生产环境下使用
                app.UseDeveloperExceptionPage();
            else
                app.UseHsts();
            //使用严格的HTTP请求传输，对于保护Web很重要
            //app.UseExceptionHandler();

            //配置Cors 配置跨域处理
            app.UseCors("Any");

            app.UseHttpsRedirection(); //跳转Https
            app.UseMvc();

            #region Swagger服务
            app.UseSwagger();
            app.UseSwaggerUI(us =>
            {
                //第一种写法
                #region 这种写法是写死固定
                us.SwaggerEndpoint("/swagger/MyWebApi/swagger.json", "MyWebApi");
                //路径配置为空，表示直接在根域名（localhost:5001）访问该文件
                //注意：localhost:5001/swagger是访问不到的，把文件launchSetting.json中把launchUrl去掉

                us.RoutePrefix = "";
                #endregion

                //第二种写法
                #region 根据版本名称倒序，遍历显示
                #endregion
            });
            //验证---官方验证方法
            app.UseAuthentication();
            #endregion
        }
    }
}
