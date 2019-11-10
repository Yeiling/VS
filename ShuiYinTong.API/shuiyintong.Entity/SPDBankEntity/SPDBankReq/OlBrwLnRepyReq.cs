using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 贷款归还请求类型
    /// </summary>
    public class OlBrwLnRepyReq
    {
        /// <summary>
        /// 平台号
        /// </summary>
        [Required(ErrorMessage = "平台号必填")]
        public string pltfrmNo { get; set; }
        /// <summary>
        /// 平台流水号
        /// </summary>
        [Required(ErrorMessage = "平台流水号必填")]
        public string pltfrmSeq { get; set; }
        /// <summary>
        /// 客户号
        /// </summary>
        [Required(ErrorMessage = "客户号必填")]
        public string clientNo { get; set; }
        /// <summary>
        /// 借据号
        /// </summary>
        [Required(ErrorMessage = "起息日必填")]
        public string duebillNo { get; set; }
        /// <summary>
        /// 还款账号
        /// </summary>
        [Required(ErrorMessage = "还款账号必填")]
        public string repayAcctNo { get; set; }
        /// <summary>
        /// 还款总额
        /// </summary>
        [Required(ErrorMessage = "还款总额必填")]
        public string repayTot { get; set; }
        /// <summary>
        /// 还本金额
        /// </summary>
        [Required(ErrorMessage = "还本金额必填")]
        public string repayPrncpl { get; set; }
        /// <summary>
        /// 还息金额
        /// </summary>
        [Required(ErrorMessage = "还息金额必填")]
        public string repayInt { get; set; }
        /// <summary>
        /// 扣款渠道
        /// </summary>
        [Required(ErrorMessage = "扣款渠道必填")]
        public string ddtChnl { get; set; }
        /// <summary>
        /// 备付金结算账号
        /// </summary>
        public string cmpnAcctNo { get; set; }
        /// <summary>
        /// 还款方式
        /// </summary>
        [Required(ErrorMessage = "还款方式必填")]
        public string repayMode { get; set; }
        /// <summary>
        /// 交易时间
        /// </summary>
        [Required(ErrorMessage = "交易时间必填")]
        public string tranDateTime { get; set; }
        /// <summary>
        /// 正常本金余额
        /// </summary>
        [Required(ErrorMessage = "正常本金余额必填")]
        public string principal { get; set; }
        /// <summary>
        /// 偿还正常本金利息
        /// </summary>
        [Required(ErrorMessage = "起息日必填")]
        public string nrmPrncplInt { get; set; }
        /// <summary>
        /// 逾期本金
        /// </summary>
        [Required(ErrorMessage = "逾期本金必填")]
        public string oduePrncpl { get; set; }
        /// <summary>
        /// 逾期本金利息
        /// </summary>
        [Required(ErrorMessage = "逾期本金利息必填")]
        public string oduePrncplInt { get; set; }
        /// <summary>
        /// 偿还表外欠息金额
        /// </summary>
        [Required(ErrorMessage = "偿还表外欠息金额必填")]
        public string repayBalOwIntAmt { get; set; }
        /// <summary>
        /// 偿还表外欠息利息
        /// </summary>
        [Required(ErrorMessage = "偿还表外欠息利息必填")]
        public string repayBalOwIntiNT { get; set; }
        /// <summary>
        /// 表内欠息利息金额
        /// </summary>
        [Required(ErrorMessage = "表内欠息利息金额必填")]
        public string onBalOweIntInt { get; set; }
        /// <summary>
        /// 表内欠息
        /// </summary>
        [Required(ErrorMessage = "表内欠息必填")]
        public string onBalOweInt { get; set; }
        /// <summary>
        /// 表外复息
        /// </summary>
        [Required(ErrorMessage = "表外复息必填")]
        public string offBalCmpdInt { get; set; }
        /// <summary>
        /// 表外复息利息金额
        /// </summary>
        [Required(ErrorMessage = "表外复息利息金额必填")]
        public string offBalCmpdIntInt { get; set; }

    }
}
