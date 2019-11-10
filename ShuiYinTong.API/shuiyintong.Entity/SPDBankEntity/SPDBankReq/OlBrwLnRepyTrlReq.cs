using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 归还贷款本金利息试算请求类型
    /// </summary>
    public class OlBrwLnRepyTrlReq
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
        /// 还款总额
        /// </summary>
        [Required(ErrorMessage = "还款总额必填")]
        public string repayTot { get; set; }
        /// <summary>
        /// 试算方式
        /// </summary>
        [Required(ErrorMessage = "试算方式必填")]
        public string repayTrlMd { get; set; }
        /// <summary>
        /// 还款账号
        /// </summary>
        [Required(ErrorMessage = "还款账号必填")]
        public string repayAcctNo { get; set; }

    }
}
