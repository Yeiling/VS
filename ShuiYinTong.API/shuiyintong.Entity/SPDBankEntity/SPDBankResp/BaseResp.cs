namespace shuiyintong.Entity.SPDBankEntity.SPDBankResp
{
    /// <summary>
    /// 返回结果基类
    /// </summary>
    public class BaseResp
    {
        /// <summary>
        /// 返回信息
        /// </summary>
        public string statusMsg { get; set; }
        /// <summary>
        /// 返回状态码“0000”-交易成功 “1000”-交易处理中 “0001”-未知错误 “0002”-参数校验失败 “0003”-异步交易失败
        /// </summary>
        public string statusCode { get; set; }
        /// <summary>
        /// 交易流水号
        /// </summary>
        public string transNo { get; set; }
    }
}
