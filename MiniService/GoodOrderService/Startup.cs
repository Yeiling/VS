using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodOrderService.ConsulReg;
using GoodOrderService.Filters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


namespace GoodOrderService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            //��ӹ�����AOP---ȫ�֣�ÿ������������Ч
            services.AddMvcCore(option =>
            {
                //option.Filters.Add(new GlobeFilter());
                //option.Filters.Add(typeof(GlobeFilter));
            });

            services.AddScoped<GlobeFilter>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //����ע�ᵽConsul����---������
            //ִֻ��һ��
            //Configuration.Register();

        }
    }
}
