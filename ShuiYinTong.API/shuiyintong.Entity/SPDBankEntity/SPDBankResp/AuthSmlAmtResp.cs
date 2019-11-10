namespace shuiyintong.Entity.SPDBankEntity.SPDBankResp
{
    /// <summary>
    /// 单笔资金划拨小额鉴权返回类型
    /// </summary>
    public class AuthSmlAmtResp: BaseResp
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
        /// 支付流水号
        /// </summary>
        public string pySeqNo { get; set; }
        /// <summary>
        /// 交易状态
        /// </summary>
        public string tranStatus { get; set; }
        /// <summary>
        /// 失败原因
        /// </summary>
        public string failRsnDsc { get; set; }

    }
}
