namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 备付金或结算户转客户结算户请求类型
    /// </summary>
    public class ZLSysInrBnkTfrReq
    {
        /// <summary>
        /// 平台号---必填
        /// </summary>
        public string pltfrmNo { get; set; }
        /// <summary>
        /// 付款人账号---必填
        /// </summary>
        public string pyrAcctNo { get; set; }
        /// <summary>
        /// 付款人名称---必填
        /// </summary>
        public string payerName { get; set; }
        /// <summary>
        /// 收款人账号---必填
        /// </summary>
        public string payeeAcctNo { get; set; }
        /// <summary>
        /// 收款人名称---必填
        /// </summary>
        public string payeeName { get; set; }
        /// <summary>
        /// 金额---必填
        /// </summary>
        public decimal tranAmt { get; set; }
        /// <summary>
        /// 电子凭证号---必填
        /// </summary>
        public string realVchrNo { get; set; }
        /// <summary>
        /// 交易摘要
        /// </summary>
        public string abstractCode { get; set; }

    }
}
