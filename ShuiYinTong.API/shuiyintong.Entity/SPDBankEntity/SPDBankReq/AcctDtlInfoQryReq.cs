using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 账户信息查询URL
    /// </summary>
    public class AcctDtlInfoQryReq
    {
        /// <summary>
        /// 账号
        /// </summary>
        [Required(ErrorMessage = "账号必填")]
        public string acctNo { get; set; }
        /// <summary>
        /// 起始日期-
        /// </summary>
        [Required(ErrorMessage = "起始日期必填")]
        public string beginDate { get; set; }
        /// <summary>
        /// 终止日期
        /// </summary>
        [Required(ErrorMessage = "终止日期必填")]
        public string endDate { get; set; }
        /// <summary>
        /// 起始笔数
        /// </summary>
        [Required(ErrorMessage = "起始笔数必填")]
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
