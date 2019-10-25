namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 根据抹账流水查原往账流水请求类型
    /// </summary>
    public class BnkInfoQryCombntnTranReq
    {
        /// <summary>
        /// 账号---必填
        /// </summary>
        public string acctNo { get; set; }
        /// <summary>
        /// 柜员流水号---必填
        /// </summary>
        public string hostSeqNo { get; set; }
        /// <summary>
        /// 交易日期---必填
        /// </summary>
        public string tranDate { get; set; }
        /// <summary>
        /// 传票组内序号---必填
        /// </summary>
        public string txnSeqNo { get; set; }

    }
}
