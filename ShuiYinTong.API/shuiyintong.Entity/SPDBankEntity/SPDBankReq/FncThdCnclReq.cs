namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 三方解约请求类型
    /// </summary>
    public class FncThdCnclReq
    {
        /// <summary>
        /// 客户号---必填
        /// </summary>
        public string clientNo { get; set; }
        /// <summary>
        /// 签约账号---必填
        /// </summary>
        public string signAcctNo { get; set; }
        /// <summary>
        /// 审批核心企业账号---必填
        /// </summary>
        public string aprCrEpClntAtNo { get; set; }
        /// <summary>
        /// 审批核心企业中文名---必填
        /// </summary>
        public string aprCrEpCltChsNm { get; set; }

    }
}
