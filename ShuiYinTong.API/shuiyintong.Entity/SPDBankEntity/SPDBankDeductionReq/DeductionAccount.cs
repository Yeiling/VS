using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankDeductionReq
{
    /// <summary>
    /// 用款项目扣款结项之后
    /// </summary>
    public class DeductionAccount
    {
        /// <summary>
        /// 平台项目编号
        /// </summary>        
        [Required(ErrorMessage = "平台项目账号必填")]
        public string platformAcctNo { get; set; }

        /// <summary>
        /// 担授合同编号
        /// </summary>
        [Required(ErrorMessage = "担授合同编号必填")]
        public string guaranteeContractNo { get; set; }

        /// <summary>
        /// 用款编号
        /// </summary>       
        [Required(ErrorMessage = "用款编号必填")]
        public string usageContractNo { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>   
        [Required(ErrorMessage = "企业名称必填")]
        public string enterpriseName { get; set; }

        /// <summary>
        /// 还款记录
        /// </summary>   
        [Required(ErrorMessage = "还款记录必填")]
        public string paymentRecord { get; set; }

        /// <summary>
        /// 放款记录
        /// </summary>   
        public string loanRecord { get; set; }

        /// <summary>
        /// 额度申请记录
        /// </summary>   
        public string quotaAppRecord { get; set; }

        /// <summary>
        /// 客户应还文件
        /// </summary>   
        public string customerDoc { get; set; }
    }
}
