namespace shuiyintong.Entity.SPDBankEntity.SPDBankResp
{
    /// <summary>
    /// 支付指令取消返回类型
    /// </summary>
    public class PayInsrCnlResp : BaseResp
    {
        /// <summary>
        /// 商户流水号
        /// </summary>
        public string mrchSeqNo { get; set; }
        /// <summary>
        /// 支付交易流水号
        /// </summary>
        public string tranSeqNo { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        public string ordrNo { get; set; }
        /// <summary>
        /// 支付指令状态 3-取消成功
        /// </summary>
        public string insrSt { get; set; }

    }
}
