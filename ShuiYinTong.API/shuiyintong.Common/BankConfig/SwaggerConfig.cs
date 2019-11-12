namespace shuiyintong.Common.BankConfig
{
    /// <summary>
    /// Swagger配置类 Token验证参数
    /// </summary>
    public class SwaggerConfig
    {
        /// <summary>
        /// 秘钥
        /// </summary>
        public string SecurityKey { get; set; }
        /// <summary>
        /// 服务端
        /// </summary>
        public string issuer { get; set; }
        /// <summary>
        /// 客户端
        /// </summary>
        public string audience { get; set; }
    }
}
