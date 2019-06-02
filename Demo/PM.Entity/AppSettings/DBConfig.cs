namespace PM.Entity.AppSettings
{
    /// <summary>
    /// 配置文件AppConfig
    /// </summary>
    public class DBConfig
    {
        /// <summary>
        /// URL访问地址
        /// </summary>
        public URL URL { get; set; }
        /// <summary>
        /// PM库
        /// </summary>
        public string Test { get; set; }
        /// <summary>
        /// 程序集名称
        /// </summary>
        public string Assembly { get; set; }
        /// <summary>
        /// 文件夹
        /// </summary>
        public string File { get; set; }
        /// <summary>
        /// 服务
        /// </summary>
        public ServerModel ServerModel { get; set; }
    }
    /// <summary>
    /// URL访问地址
    /// </summary>
    public struct URL
    {
        /// <summary>
        ///默认访问地址
        /// </summary>
        public string DefaultURL { get; set; }
    }
    /// <summary>
    /// 接口类配置文件
    /// </summary>
    public class ServerModel
    {
        public string DeptService { get; set; }
        public string EmpService { get; set; }
    }

}
