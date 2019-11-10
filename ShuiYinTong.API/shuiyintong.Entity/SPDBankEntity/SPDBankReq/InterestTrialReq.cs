using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 贷款试算请求类型
    /// </summary>
    public class InterestTrialReq
    {
        /// <summary>
        /// 起息日
        /// </summary>
        [Required(ErrorMessage = "起息日必填")]
        public string dstrDt { get; set; }
        /// <summary>
        /// 到期日
        /// </summary>
        [Required(ErrorMessage = "到期日必填")]
        public string expiredDate { get; set; }
        /// <summary>
        /// 贷款金额
        /// </summary>
        [Required(ErrorMessage = "贷款金额必填")]
        public string anlDstrPyAmt { get; set; }
        /// <summary>
        /// 贷款利率
        /// </summary>
        [Required(ErrorMessage = "贷款利率必填")]
        public string execIntRate { get; set; }
        /// <summary>
        /// 还款方式
        /// </summary>
        [Required(ErrorMessage = "还款方式必填")]
        public string repayMode { get; set; }
        /// <summary>
        /// 首次结息日期
        /// </summary>
        public string setlIntDt { get; set; }
        /// <summary>
        /// 起始笔数-
        /// </summary>
        [Required(ErrorMessage = "起始笔数必填")]
        public string startNum { get; set; }
        /// <summary>
        /// 查询笔数
        /// </summary>
        [Required(ErrorMessage = "查询笔数必填")]
        public string queryNum { get; set; }

    }
}
