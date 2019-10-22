namespace shuiyintong.Entity
{
    /// <summary>
    /// 日志数据类型
    /// </summary>
    public class BaseLog
    {
        public int Code { get; set; }
        public string ErrorMsg { get; set; }
        public string DateTime { get; set; }
        public string API { get; set; }
    }
}
