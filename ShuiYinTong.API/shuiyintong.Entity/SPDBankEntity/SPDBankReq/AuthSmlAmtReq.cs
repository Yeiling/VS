namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 单笔资金划拨小额鉴权请求类型
    /// </summary>
    public class AuthSmlAmtReq
    {
        /// <summary>
        /// 商户编号---必填
        /// </summary>
        public string mrchId { get; set; }
        /// <summary>
        /// 交易流水号---必填
        /// </summary>
        public string tranSeqNo { get; set; }
        /// <summary>
        /// 商户日期时间---必填
        /// </summary>
        public string mrchDateTim { get; set; }
        /// <summary>
        /// 渠道标志---必填
        /// </summary>
        public string channel { get; set; }
        /// <summary>
        /// 付款人账号---必填
        /// </summary>
        public string pyrAcctNo { get; set; }
        /// <summary>
        /// 付款人名称---必填
        /// </summary>
        public string payerName { get; set; }
        /// <summary>
        /// 收款人账号---必填
        /// </summary>
        public string payeeAcctNo { get; set; }
        /// <summary>
        /// 收款人名称---必填
        /// </summary>
        public string payeeName { get; set; }
        /// <summary>
        /// 收款行行号
        /// </summary>
        public string payeeBranchId { get; set; }
        /// <summary>
        /// 收款行行名---必填
        /// </summary>
        public string payeeBranchName { get; set; }
        /// <summary>
        /// 附言
        /// </summary>
        public string postscript { get; set; }
        ///// <summary>
        ///// 摘要
        ///// </summary>
        //public string abstract{ get; set; }

    }
}
