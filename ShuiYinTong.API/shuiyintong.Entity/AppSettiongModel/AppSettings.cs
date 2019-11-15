namespace shuiyintong.Entity.AppSettiongModel
{
    /// <summary>
    /// AppSettiong对象
    /// </summary>
    public static class AppSettings
    {
        /// <summary>
        /// 允许主机IP
        /// </summary>
        public static string AllowedHosts { get; set; }
        /// <summary>
        /// 日志配置
        /// </summary>
        public static Logging Logging { get; set; }
        /// <summary>
        /// Swagger配置
        /// </summary>
        public static SwaggerConfig SwaggerConfig { get; set; }
        /// <summary>
        /// DB数据库配置
        /// </summary>
        public static DBConfig DBConfig { get; set; }
        /// <summary>
        /// Redis配置
        /// </summary>
        public static RedisConfig RedisConfig { get; set; }
        /// <summary>
        /// 银行配置
        /// </summary>
        public static BankConfig BankConfig { get; set; }
    }

}
