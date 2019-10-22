namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 单笔划拨接查询请求
    /// </summary>
    public class SnglTrsfRstlQryReq
    {
        /// <summary>
        /// 商户流水号---必填
        /// </summary>
        public string merSeqno { get; set; }
        /// <summary>
        /// 付款人账号---必填
        /// </summary>
        public string payAcct { get; set; }

    }
}
