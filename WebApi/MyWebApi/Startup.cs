using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using System.Collections.Generic;
using System.IO;
namespace MyWebApi
{
    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 配置
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        /// <summary>
        /// 
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// 
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
                    Title = "My WebApi",  //主题
                    Description = "WebApi框架",  //描述
                    TermsOfService = null,
                    Contact = new Contact() { Name = "CaiHui", Url = "www.baidu.com", Email = "123@qq.com" }
                });
                //添加读取注释服务
                var basePath = PlatformServices.Default.Application.ApplicationBasePath;

                //读取控制器API
                var xmlPath = Path.Combine(basePath, "MyWebApi.xml");
                sgo.IncludeXmlComments(xmlPath, true);
                //读取实体类文件
                var entityXmlPath = Path.Combine(basePath, "ClassLibrary.xml");
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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();


            #region Swagger服务
            app.UseSwagger();
            app.UseSwaggerUI(us =>
            {
                us.SwaggerEndpoint("/swagger/MyWebApi/swagger.json", "MyWebApi");
            });
            #endregion
        }
    }
}
