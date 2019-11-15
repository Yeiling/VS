namespace shuiyintong.Entity.AppSettiongModel
{
    /// <summary>
    /// DB数据库配置
    /// </summary>
    public class DBConfig
    {
        /// <summary>
        /// 数据库类型
        /// </summary>
        public int DbType { get; set; }
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public string DBConn { get; set; }
    }
}
