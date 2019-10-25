namespace shuiyintong.Entity.SPDBankEntity.SPDResp
{
    /// <summary>
    /// 根据抹账流水查原往账流水请返回类型
    /// </summary>
    public class BnkInfoQryCombntnTranResp
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
        /// 柜员流水号
        /// </summary>
        public string hostSeqNo { get; set; }
        /// <summary>
        /// 交易日期
        /// </summary>
        public string tranDate { get; set; }
        /// <summary>
        /// 原柜员流水号
        /// </summary>
        public string origHostSeqNo { get; set; }
        /// <summary>
        /// 原交易日期
        /// </summary>
        public string origTranDate { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        public string acctNo { get; set; }
        /// <summary>
        /// 原往账传票组内序号
        /// </summary>
        public string origTxnSeqNo { get; set; }

    }
}
