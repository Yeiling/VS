namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 支付指令明细查询请求类型
    /// </summary>
    public class PayInsrDtlQryReq
    {
        /// <summary>
        /// 商户编号---必填
        /// </summary>
        public string mrchId { get; set; }
        /// <summary>
        /// 商户流水号---必填
        /// </summary>
        public string mrchSeqNo { get; set; }
        /// <summary>
        /// 商户交易日期---必填
        /// </summary>
        public string tranDate { get; set; }

    }
}
