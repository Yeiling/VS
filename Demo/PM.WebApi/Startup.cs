using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
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
        /// ConfigureServices
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

            //添加cors 服务 配置跨域处理            
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
                //使用严格的HTTP请求传输，对于保护Web很重要
                //app.UseHsts();
                app.UseExceptionHandler();

            //配置Cors 配置跨域处理
            app.UseCors("any");

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
                //us.RoutePrefix = "";
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
