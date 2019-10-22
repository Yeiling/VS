using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using shuiyintong.DBUtils.IService;
using shuiyintong.DBUtils.Service;
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
        /// 构造函数
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// 配置属性
        /// </summary>
        public IConfiguration Configuration { get; }
        //IServiceProvider--- This method gets called by the runtime. Use this method to add services to the container.
        /// <summary>
        /// 配置服务
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // 注册Swagger服务
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "ShuiYinTong.WebApi", Version = "v1" });
                //添加xml文件

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

            });

            services.Replace(ServiceDescriptor.Transient<IControllerActivator, ServiceBasedControllerActivator>());

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.UseJsonConfig(Configuration);

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

            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterGeneric(typeof(BaseService<>)).As(typeof(IBaseService<>));

            containerBuilder.RegisterAssemblyTypes(Assembly.Load("shuiyintong.Api")).PropertiesAutowired();

            containerBuilder.Populate(services);
            var container = containerBuilder.Build();
            return new AutofacServiceProvider(container);
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
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseHttpsRedirection();

            // 启用Swagger中间件
            app.UseSwagger();
            // 配置SwaggerUI
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ShuiYinTong.WebApi");
                c.RoutePrefix = string.Empty;
            });

            app.UseMvc(routes =>
            {
                //扩展路由
                routes.MapRoute("default", "/{controller}/{action}/{id?}", new { controller = "Home", action = "Index" });
            });

        }
    }
}
