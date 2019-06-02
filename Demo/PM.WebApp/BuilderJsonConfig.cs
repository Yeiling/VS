using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using PM.Entity.AppSettings;
using System;

namespace PM.WebApp
{
    public static class BuilderJsonConfig
    {
        private static IDisposable callbackRegistration;
        public static void UseJsonConfig(this IServiceCollection services, IConfiguration configuration)
        {
            callbackRegistration = configuration.GetSection("DBConfig").GetReloadToken().RegisterChangeCallback(OnDBConfigChanged, configuration.GetSection("DBConfig"));
            Config.DBConfig = services.Configure<DBConfig>(configuration.GetSection("DBConfig")).BuildServiceProvider().GetService<IOptionsSnapshot<DBConfig>>().Value;

            callbackRegistration = configuration.GetSection("Setting").GetReloadToken().RegisterChangeCallback(OnSettingChanged, configuration.GetSection("Setting"));
            Config.Setting = services.Configure<Setting>(configuration.GetSection("Setting")).BuildServiceProvider().GetService<IOptionsSnapshot<Setting>>().Value;
        }

        private static void OnDBConfigChanged(object state)
        {
            callbackRegistration?.Dispose();
            IConfiguration configuration = (IConfiguration)state;
            Config.DBConfig = configuration.Get<DBConfig>();
            callbackRegistration = configuration.GetReloadToken().RegisterChangeCallback(OnDBConfigChanged, state);
        }
        private static void OnSettingChanged(object state)
        {
            callbackRegistration?.Dispose();
            IConfiguration configuration = (IConfiguration)state;
            Config.Setting = configuration.Get<Setting>();
            callbackRegistration = configuration.GetReloadToken().RegisterChangeCallback(OnSettingChanged, state);
        }
    }
}
