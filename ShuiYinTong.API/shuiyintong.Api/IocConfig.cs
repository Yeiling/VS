using Autofac;
using Autofac.Annotation;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using shuiyintong.Api.AutoFacAop;
using shuiyintong.Api.Tool;
using shuiyintong.DBUtils.IService;
using shuiyintong.DBUtils.Service;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;

namespace shuiyintong.Api
{
    /// <summary>
    /// AutoFac IOC扩展
    /// </summary>
    public static class IocConfig
    {
        /// <summary>
        /// AutoFac 属性注入和AOP注入
        /// </summary>
        /// <param name="builder"></param>
        public static void AutoFacIoc(this ContainerBuilder builder)
        {
            //所有的控制器类注入属性和AOP
            //程序集
            //var assembly = builder.GetType().GetTypeInfo().Assembly;
            ////1：AOP注入IOC容易
            //builder.RegisterType<LogInterceptor>();
            ////2：控制器注入AOP容器
            //builder.RegisterAssemblyTypes(assembly)
            //    .Where(type => typeof(ControllerBase).IsAssignableFrom(type) && !type.GetTypeInfo().IsAbstract)
            //    .AsImplementedInterfaces()
            //    .InstancePerLifetimeScope()
            //    .EnableInterfaceInterceptors()
            //    .InterceptedBy(typeof(LogInterceptor));
            ////3:数据库服务注入
            //builder.RegisterGeneric(typeof(BaseService<>)).As(typeof(IBaseService<>));

            var assembly = typeof(Startup).Assembly.GetExportedTypes()
            .Where(type => typeof(ControllerBase).IsAssignableFrom(type)).ToArray();
            //1：AOP注入IOC容易
            builder.RegisterType<LogInterceptor>();
            //2：控制器注入AOP容器---AOP调试没有达到预期效果
            builder.RegisterTypes(assembly).PropertiesAutowired();
            //.Where(type => typeof(ControllerBase).IsAssignableFrom(type))
            //.InterceptedBy(typeof(LogInterceptor))
            //.EnableClassInterceptors();

            //3:数据库服务注入---AOP可实现
            builder.RegisterGeneric(typeof(BaseService<>)).As(typeof(IBaseService<>)).InterceptedBy(typeof(LogInterceptor)).EnableInterfaceInterceptors();
            //4：Redis服务注册
            //builder.RegisterGeneric(typeof(RediServer<>)).As(typeof(IRediServer<>)).InterceptedBy(typeof(LogInterceptor)).EnableInterfaceInterceptors();
            builder.RegisterType(typeof(RediServer)).As(typeof(IRediServer)).InterceptedBy(typeof(LogInterceptor)).EnableInterfaceInterceptors();
            //Swagger文件导出注入
            builder.RegisterType<IHostingEnvironment>();
            builder.RegisterType<SpireDocHelper>();
            builder.RegisterType<SwaggerGenerator>();
        }
    }
}
