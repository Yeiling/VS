namespace shuiyintong.Entity.SPDBankEntity.SPDResp
{
    /// <summary>
    /// 单笔划拨结果查询返回结果对象
    /// </summary>
    public class SnglTrsfRstlQryResp
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
        /// 交易状态
        /// </summary>
        public string transStatus { get; set; }
        /// <summary>
        /// 核心流水
        /// </summary>
        public string hostSeqNo { get; set; }
        /// <summary>
        /// 核心日期
        /// </summary>
        public string hostDate { get; set; }
        /// <summary>
        /// 核心时间
        /// </summary>
        public string hostTime { get; set; }
        /// <summary>
        /// 往账支付业务编号
        /// </summary>
        public string payBussId { get; set; }
        /// <summary>
        /// 传票组内序号
        /// </summary>
        public string txnSeqNo { get; set; }

    }
}
