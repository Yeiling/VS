namespace shuiyintong.Entity.SPDBankEntity.SPDBankResp
{
    /// <summary>
    /// 借据详细信息查看返回类型
    /// </summary>
    public class LnRcrdDtlQryResp : BaseResp
    {
        /// <summary>
        /// 平台号
        /// </summary>
        public string pltfrmNo { get; set; }
        /// <summary>
        /// 客户号
        /// </summary>
        public string clientNo { get; set; }
        /// <summary>
        /// 贷款币种
        /// </summary>
        public string loanCode { get; set; }
        /// <summary>
        /// 贷款形式
        /// </summary>
        public string loanMode { get; set; }
        /// <summary>
        /// 贷款用途
        /// </summary>
        public string loanUsageDsc { get; set; }
        /// <summary>
        /// 借据号
        /// </summary>
        public string duebillNo { get; set; }
        /// <summary>
        /// 借据起息日
        /// </summary>
        public string startIntDate { get; set; }
        /// <summary>
        /// 借据到期日
        /// </summary>
        public string dublEfctDate { get; set; }
        /// <summary>
        /// 发放金额
        /// </summary>
        public string dstrAmt { get; set; }
        /// <summary>
        /// 贷款入账账号
        /// </summary>
        public string loanInAcctNo { get; set; }
        /// <summary>
        /// 还款账号
        /// </summary>
        public string repayAcctNo { get; set; }
        /// <summary>
        /// 执行年利率
        /// </summary>
        public string execYearIntRate { get; set; }
        /// <summary>
        /// 还款方式
        /// </summary>
        public string repayMode { get; set; }
        /// <summary>
        /// 下次结息日期
        /// </summary>
        public string nxtIntSetlDt { get; set; }
        /// <summary>
        /// 逾期计息方式
        /// </summary>
        public string odueIntActualMode { get; set; }
        /// <summary>
        /// 逾期罚息浮动比率
        /// </summary>
        public string oduePnyIntFltRt { get; set; }
        /// <summary>
        /// 本金余额
        /// </summary>
        public string loanBal { get; set; }
        /// <summary>
        /// 贷款性质
        /// </summary>
        public string loanChartic { get; set; }
    }
}
