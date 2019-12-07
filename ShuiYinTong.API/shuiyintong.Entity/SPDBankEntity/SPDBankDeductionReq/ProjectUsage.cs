using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankDeductionReq
{
    /// <summary>
    /// 用款--银行审批请求类型
    /// </summary>
    public class ProjectUsage
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
        /// 审批意见：1通过/0拒绝
        /// </summary>      
        [Required(ErrorMessage = "审批意见必填(1:通过 0:拒绝)")]
        public bool approvalOpinion { get; set; }

        /// <summary>
        /// 备注
        /// </summary>           
        public string remarks { get; set; }

        /// <summary>
        /// 当前授信额度
        /// </summary>      
        [Required(ErrorMessage = "当前授信额度必填")]
        public string currentCreditAmount { get; set; }

        /// <summary>
        /// 单笔用款额度
        /// </summary>      
        [Required(ErrorMessage = "单笔用款额度必填")]
        public string singlePaymentAmount { get; set; }

        /// <summary>
        /// 企业及关键人是否满足人行征信准入条件：是/否
        /// </summary>           
        public bool? IsFitReq { get; set; }

        /// <summary>
        /// 企业销贷比（分值）
        /// </summary>           
        public string proportion { get; set; }

        /// <summary>
        /// 企业未结清贷款余额（分值）
        /// </summary>           
        public string outstandFrequency { get; set; }

        /// <summary>
        /// 企业法定代表人最近24个自然月最高连续逾期次数（分值）
        /// </summary>           
        public string overdueFrequency { get; set; }

        /// <summary>
        /// 企业法定代表人最近24个自然月累计逾期次数（分值）
        /// </summary>           
        public string overdueTotalFrequency { get; set; }

    }
}
