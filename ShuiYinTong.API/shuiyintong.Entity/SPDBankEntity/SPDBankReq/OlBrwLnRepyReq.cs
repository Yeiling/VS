namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 贷款归还请求类型
    /// </summary>
    public class OlBrwLnRepyReq
    {
        /// <summary>
        /// 平台号---必填
        /// </summary>
        public string pltfrmNo { get; set; }
        /// <summary>
        /// 平台流水号---必填
        /// </summary>
        public string pltfrmSeq { get; set; }
        /// <summary>
        /// 客户号---必填
        /// </summary>
        public string clientNo { get; set; }
        /// <summary>
        /// 借据号---必填
        /// </summary>
        public string duebillNo { get; set; }
        /// <summary>
        /// 还款账号---必填
        /// </summary>
        public string repayAcctNo { get; set; }
        /// <summary>
        /// 还款总额---必填
        /// </summary>
        public string repayTot { get; set; }
        /// <summary>
        /// 还本金额---必填
        /// </summary>
        public string repayPrncpl { get; set; }
        /// <summary>
        /// 还息金额---必填
        /// </summary>
        public string repayInt { get; set; }
        /// <summary>
        /// 扣款渠道---必填
        /// </summary>
        public string ddtChnl { get; set; }
        /// <summary>
        /// 备付金结算账号
        /// </summary>
        public string cmpnAcctNo { get; set; }
        /// <summary>
        /// 还款方式---必填
        /// </summary>
        public string repayMode { get; set; }
        /// <summary>
        /// 交易时间---必填
        /// </summary>
        public string tranDateTime { get; set; }
        /// <summary>
        /// 正常本金余额---必填
        /// </summary>
        public string principal { get; set; }
        /// <summary>
        /// 偿还正常本金利息---必填
        /// </summary>
        public string nrmPrncplInt { get; set; }
        /// <summary>
        /// 逾期本金---必填
        /// </summary>
        public string oduePrncpl { get; set; }
        /// <summary>
        /// 逾期本金利息---必填
        /// </summary>
        public string oduePrncplInt { get; set; }
        /// <summary>
        /// 偿还表外欠息金额---必填
        /// </summary>
        public string repayBalOwIntAmt { get; set; }
        /// <summary>
        /// 偿还表外欠息利息---必填
        /// </summary>
        public string repayBalOwIntiNT { get; set; }
        /// <summary>
        /// 表内欠息利息金额---必填
        /// </summary>
        public string onBalOweIntInt { get; set; }
        /// <summary>
        /// 表内欠息---必填
        /// </summary>
        public string onBalOweInt { get; set; }
        /// <summary>
        /// 表外复息---必填
        /// </summary>
        public string offBalCmpdInt { get; set; }
        /// <summary>
        /// 表外复息利息金额---必填
        /// </summary>
        public string offBalCmpdIntInt { get; set; }

    }
}
