using System;
using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankDeductionReq
{
    /// <summary>
    /// 结项信息
    /// </summary>
    public class NodeItemInfo
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
        /// 偿还金额
        /// </summary>   
        [Required(ErrorMessage = "偿还金额必填")]
        public string repaymentAmount { get; set; }

        /// <summary>
        /// 偿还日期
        /// </summary>   
        [Required(ErrorMessage = "偿还日期必填")]
        public DateTime repaymentDate { get; set; }

        /// <summary>
        /// 逾期天数
        /// </summary>   
        [Required(ErrorMessage = "逾期天数必填")]
        public string overdueDays { get; set; }

        /// <summary>
        /// 罚息金额
        /// </summary>   
        [Required(ErrorMessage = "罚息金额必填")]
        public string penaltyAmount { get; set; }

    }
}
