using System;
using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankDeductionReq
{
    /// <summary>
    /// 代偿信息
    /// </summary>
    public class CompensationInfo
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
        /// 代偿金额
        /// </summary>   
        [Required(ErrorMessage = "代偿金额必填")]
        public string compensationAmount { get; set; }

        /// <summary>
        /// 代偿日期
        /// </summary>   
        [Required(ErrorMessage = "代偿日期必填")]
        public DateTime compensationDate { get; set; }
    }
}
