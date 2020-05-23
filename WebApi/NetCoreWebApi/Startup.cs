using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ServiceLibrary;
using ServiceLibrary.Config;

namespace NetCoreWebApi
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

            //ע��TestDI---ʹ��Ĭ�Ϲ��캯��
            //services.AddScoped<TestDI>();

            //ע��TestDI---ʹ�ô��������캯��
            //services.AddScoped(s => new TestDIOne(new ConfigOption
            //{
            //    Key = "qazwsx"
            //}));

            //ʹ��Ĭ�Ϲ��캯��
            //services.AddScoped(typeof(TestDInterface), typeof(TestDIOne));


            //ʹ�ô��������캯���������֣�
            services.AddScoped<TestDInterface>(provider =>
            {
                return new TestDIOne(new ConfigOption
                {
                    Key = "123"
                });
            });

            //services.AddScoped<TestDInterface, TestDITwo>(provider =>
            //{
            //    return new TestDITwo(new ConfigOption
            //    {
            //        Key = "123"
            //    });
            //});



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
        }
    }
}
