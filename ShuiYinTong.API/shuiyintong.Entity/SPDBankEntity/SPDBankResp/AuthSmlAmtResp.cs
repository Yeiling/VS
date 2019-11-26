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
        /// 交易状态 00-成功（本行） 01-失败 16-受理成功（跨行） 99-超时
        /// </summary>
        public string tranStatus { get; set; }
        /// <summary>
        /// 失败原因 如交易状态为“受理成功”，该字段为提示信息“转账指令已受理，请勿重复转账”
        /// </summary>
        public string failRsnDsc { get; set; }

    }
}
