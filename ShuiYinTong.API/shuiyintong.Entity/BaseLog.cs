namespace shuiyintong.Entity
{
    /// <summary>
    /// 日志数据类型
    /// </summary>
    public class BaseLog
    {
        /// <summary>
        /// Http code
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrorMsg { get; set; }
        /// <summary>
        /// 请求时间
        /// </summary>
        public string DateTime { get; set; }
        /// <summary>
        /// 接口编号
        /// </summary>
        public int APICode { get; set; }
        /// <summary>
        /// 接口名称
        /// </summary>
        public string APIName { get; set; }

    }
}
