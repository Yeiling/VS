using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 对公贷款还款维护请求类型
    /// </summary>
    public class CorpLnCntlAcctReq
    {
        /// <summary>
        /// 平台号
        /// </summary>
        [Required(ErrorMessage = "平台号必填")]
        public string pltfrmNo { get; set; }
        /// <summary>
        /// 客户号
        /// </summary>
        [Required(ErrorMessage = "客户号必填")]
        public string clientNo { get; set; }
        /// <summary>
        /// 借据号
        /// </summary>
        [Required(ErrorMessage = "借据号必填")]
        public string duebillNo { get; set; }
        /// <summary>
        /// 贷款账号
        /// </summary>
        public string loanAcctNo { get; set; }
        /// <summary>
        /// 还款账号
        /// </summary>
        [Required(ErrorMessage = "还款账号必填")]
        public string repayAcctNo { get; set; }
        /// <summary>
        /// 还款总额
        /// </summary>
        public string repayTot { get; set; }
        /// <summary>
        /// 还本金额
        /// </summary>
        public string repayPrncpl { get; set; }
        /// <summary>
        /// 还款方式
        /// </summary>
        [Required(ErrorMessage = "还款方式必填")]
        public string repayMode { get; set; }
        /// <summary>
        /// 正常本金余额
        /// </summary>
        public string principal { get; set; }
        /// <summary>
        /// 偿还正常本金利息
        /// </summary>
        public string nrmPrncplInt { get; set; }
        /// <summary>
        /// 逾期本金
        /// </summary>
        public string oduePrncpl { get; set; }
        /// <summary>
        /// 逾期本金利息
        /// </summary>
        public string oduePrncplInt { get; set; }
        /// <summary>
        /// 偿还表外欠息金额
        /// </summary>
        public string repayBalOwIntAmt { get; set; }
        /// <summary>
        /// 偿还表外欠息利息
        /// </summary>
        public string repayBalOwIntiNT { get; set; }
        /// <summary>
        /// 偿还表内欠息利息金额
        /// </summary>
        public string onBalOweIntInt { get; set; }
        /// <summary>
        /// 偿还表内欠息
        /// </summary>
        public string onBalOweInt { get; set; }
        /// <summary>
        /// 偿还表外复息
        /// </summary>
        public string offBalCmpdInt { get; set; }
        /// <summary>
        /// 偿还表外复息利息金额
        /// </summary>
        public string offBalCmpdIntInt { get; set; }

    }
}
