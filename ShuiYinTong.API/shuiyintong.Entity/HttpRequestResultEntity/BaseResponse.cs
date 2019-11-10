namespace shuiyintong.Entity.HttpRequestResultEntity
{
    /// <summary>
    /// 返回结果基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseResponse<T>
    {
        /// <summary>
        /// 返回类型
        /// </summary>
        public byte ResponseType { get; set; }
        /// <summary>
        /// http code
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// 返回数据
        /// </summary>
        public T Data { get; set; }
        /// <summary>
        /// 请求时间
        /// </summary>
        public string DateTime { get; set; }
    }
}
