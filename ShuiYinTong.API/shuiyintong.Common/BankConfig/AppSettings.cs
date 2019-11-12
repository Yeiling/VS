namespace shuiyintong.Common.BankConfig
{
    /// <summary>
    /// appsettings.json配置文件类
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// Swagger JWT授权Token验证配置类
        /// </summary>
        public static SwaggerConfig SwaggerConfig { get; set; }
        /// <summary>
        /// 银行配置类
        /// </summary>
        public static BankConfig BankConfig { get; set; }

    }
}
