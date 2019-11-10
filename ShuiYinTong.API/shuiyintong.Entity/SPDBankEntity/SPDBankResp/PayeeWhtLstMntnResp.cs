namespace shuiyintong.Entity.SPDBankEntity.SPDBankResp
{
    /// <summary>
    /// 收款人白名单维护返回类型
    /// </summary>
    public class PayeeWhtLstMntnResp : BaseResp
    {
        /// <summary>
        /// 商户编号
        /// </summary>
        public string mrchId { get; set; }
        /// <summary>
        /// 白名单编号
        /// </summary>
        public string spclListNo { get; set; }
        /// <summary>
        /// 三方签约账号
        /// </summary>
        public string acctNo { get; set; }
        /// <summary>
        /// 入金账号
        /// </summary>
        public string pyAcctNo { get; set; }
        /// <summary>
        /// 入金账户名
        /// </summary>
        public string pyeAcctNm { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string acctNoStatus { get; set; }
        /// <summary>
        /// 生效时间
        /// </summary>
        public string effectTimes { get; set; }
        /// <summary>
        /// 失效时间
        /// </summary>
        public string losEffectTimeps { get; set; }

    }
}
