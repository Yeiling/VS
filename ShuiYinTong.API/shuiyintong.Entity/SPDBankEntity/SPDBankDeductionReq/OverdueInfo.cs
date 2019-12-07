using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankDeductionReq
{
    /// <summary>
    /// 与逾期信息
    /// </summary>
    public class OverdueInfo
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
        /// 应还金额
        /// </summary>   
        [Required(ErrorMessage = "应还金额必填")]
        public string payableAmount { get; set; }

        /// <summary>
        /// 项目状态
        /// </summary>   
        [Required(ErrorMessage = "项目状态必填（逾期/未逾期）")]
        public string projectStatus { get; set; }
    }
}
