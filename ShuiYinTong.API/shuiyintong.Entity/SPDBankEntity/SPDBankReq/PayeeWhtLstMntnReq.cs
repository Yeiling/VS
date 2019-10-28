namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 收款人白名单维护请求类型
    /// </summary>
    public class PayeeWhtLstMntnReq
    {
        /// <summary>
        /// 状态---必填
        /// </summary>
        public string acctNoStatus { get; set; }
        /// <summary>
        /// 三方签约账号---必填
        /// </summary>
        public string acctNo { get; set; }
        /// <summary>
        /// 白名单编号
        /// </summary>
        public string spclListNo { get; set; }
        /// <summary>
        /// 入金账号类型
        /// </summary>
        public string acctNoType { get; set; }
        /// <summary>
        /// 入金账号
        /// </summary>
        public string pyAcctNo { get; set; }
        /// <summary>
        /// 入金账户名
        /// </summary>
        public string pyeAcctNm { get; set; }

    }
}
