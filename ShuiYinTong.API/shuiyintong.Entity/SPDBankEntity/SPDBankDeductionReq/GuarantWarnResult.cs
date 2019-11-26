using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankDeductionReq
{
    /// <summary>
    /// 接收担保所推送预警后的处理结果以及意见
    /// </summary>
    public class GuarantWarnResult
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
        /// 预警事件编号
        /// </summary>     
        [Required(ErrorMessage = "预警事件编号必填")]
        public decimal guarantNo { get; set; }

        /// <summary>
        /// 处理情况说明描述
        /// </summary>     
        public decimal treatmentExplain { get; set; }
    }
}
