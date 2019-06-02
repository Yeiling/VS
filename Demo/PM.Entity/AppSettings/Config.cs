namespace PM.Entity.AppSettings
{
    /// <summary>
    /// Config，存储配置对象
    /// </summary>
    public struct Config
    {
        /// <summary>
        /// 配置参数
        /// </summary>
        public static DBConfig DBConfig { get; set; }
        /// <summary>
        /// 系统设置参数
        /// </summary>
        public static Setting Setting { get; set; }
    }
}
