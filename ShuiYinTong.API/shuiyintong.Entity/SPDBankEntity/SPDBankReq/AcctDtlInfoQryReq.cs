namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 账户信息查询URL
    /// </summary>
    public class AcctDtlInfoQryReq
    {
        /// <summary>
        /// 账号---必填
        /// </summary>
        public string acctNo { get; set; }
        /// <summary>
        /// 起始日期---必填
        /// </summary>
        public string beginDate { get; set; }
        /// <summary>
        /// 终止日期---必填
        /// </summary>
        public string endDate { get; set; }
        /// <summary>
        /// 起始笔数---必填
        /// </summary>
        public string beginNumber { get; set; }
        /// <summary>
        /// 交易金额
        /// </summary>
        public string transAmt { get; set; }
        /// <summary>
        /// 对方帐号
        /// </summary>
        public string oppositeAcctNo { get; set; }
        /// <summary>
        /// 对方名称
        /// </summary>
        public string oppositeName { get; set; }

    }
}
