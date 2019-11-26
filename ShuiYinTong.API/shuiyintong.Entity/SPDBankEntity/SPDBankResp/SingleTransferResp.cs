namespace shuiyintong.Entity.SPDBankEntity.SPDResp
{
    /// <summary>
    /// 单笔划拨返回类型
    /// </summary>
    public class SingleTransferResp
    {
        /// <summary>
        /// 返回信息
        /// </summary>
        public string statusMsg { get; set; }
        /// <summary>
        /// 返回状态码
        /// </summary>
        public string statusCode { get; set; }
        /// <summary>
        /// 交易流水号
        /// </summary>
        public string transNo { get; set; }
        /// <summary>
        /// 商户编号
        /// </summary>
        public string mercCode { get; set; }
        /// <summary>
        /// 商户流水号
        /// </summary>
        public string merSeqno { get; set; }
        /// <summary>
        /// 支付流水号
        /// </summary>
        public string acqSsn { get; set; }
        /// <summary>
        /// 行内行外标志
        /// </summary>
        public string spdbFlag { get; set; }
        /// <summary>
        /// 汇路标志
        /// </summary>
        public string remitFlag { get; set; }
        /// <summary>
        /// 真实凭证号
        /// </summary>
        public string realVchrNo { get; set; }
        /// <summary>
        /// 受理编号
        /// </summary>
        public string handleSeqNo { get; set; }
        /// <summary>
        /// 付款人账号
        /// </summary>
        public string payAcct { get; set; }
        /// <summary>
        /// 付款人名称
        /// </summary>
        public string payAcctName { get; set; }
        /// <summary>
        /// 收款人账号
        /// </summary>
        public string rcvAcct { get; set; }
        /// <summary>
        /// 收款人名称
        /// </summary>
        public string rcvAcctName { get; set; }
        /// <summary>
        /// 收款行行号
        /// </summary>
        public string rcvBankId { get; set; }
        /// <summary>
        /// 收款行行名
        /// </summary>
        public string rcvBankName { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public string transAmt { get; set; }
        /// <summary>
        /// 交易摘要
        /// </summary>
        public string transDigest { get; set; }
        /// <summary>
        /// 交易状态00-成功（本行）;  01-失败;  16-受理成功（跨行）;  99-超时
        /// </summary>
        public string transStatus { get; set; }

    }
}
