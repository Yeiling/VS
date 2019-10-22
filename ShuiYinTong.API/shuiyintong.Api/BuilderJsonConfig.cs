using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using shuiyintong.Common.BankConfig;

namespace shuiyintong.Api
{
    /// <summary>
    /// 读取配置文件
    /// </summary>
    public static class BuilderJsonConfig
    {
        /// <summary>
        /// 实现
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>

        public static void UseJsonConfig(this IServiceCollection services, IConfiguration configuration)
        {
            callbackRegistration = configuration.GetSection("AppSettings").GetReloadToken().RegisterChangeCallback(OnAppConfigChanged, configuration.GetSection("AppSettings"));
            AppSettings.BankConfig = services.Configure<BankConfig>(configuration.GetSection("BankConfig")).BuildServiceProvider().GetService<IOptionsSnapshot<BankConfig>>().Value;
        }

        private static System.IDisposable callbackRegistration;

        private static void OnAppConfigChanged(object state)
        {
            callbackRegistration?.Dispose();
            IConfiguration configuration = (IConfiguration)state;
            AppSettings.BankConfig = configuration.Get<BankConfig>();
            callbackRegistration = configuration.GetReloadToken().RegisterChangeCallback(OnAppConfigChanged, state);

            //if (AppSettings.BankConfig != null)
            //    AppSettings.LoadSettings();
            //AppSettings.BankConfig.SPDBankConfig = string.Format(Settings.BankConfig.SPDBankConfig, Tool.GetAdDataConnection());
        }
    }
}
