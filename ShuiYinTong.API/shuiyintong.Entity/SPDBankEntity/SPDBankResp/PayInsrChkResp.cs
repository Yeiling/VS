namespace shuiyintong.Entity.SPDBankEntity.SPDBankResp
{
    /// <summary>
    /// 支付指令登记返回类型
    /// </summary>
    public class PayInsrChkResp : BaseResp
    {
        /// <summary>
        /// 商户编号
        /// </summary>
        public string mrchId { get; set; }
        /// <summary>
        /// 商户流水号
        /// </summary>
        public string mrchSeqNo { get; set; }
        /// <summary>
        /// 商户交易日期
        /// </summary>
        public string tranDate { get; set; }
        /// <summary>
        /// 支付交易流水号
        /// </summary>
        public string tranSeqNo { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        public string ordrNo { get; set; }
        /// <summary>
        /// 指令创建时间
        /// </summary>
        public string insrCreateTimep { get; set; }
        /// <summary>
        /// 支付指令状态
        /// </summary>
        public string insrSt { get; set; }

    }
}
