using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankDeductionReq
{
    /// <summary>
    /// 授信---项目审批信息请求类型
    /// </summary>
    public class ProjectApproval
    {
        /// <summary>
        /// 平台项目账号
        /// </summary>
        [Required(ErrorMessage = "平台项目账号必填")]
        public string platformAcctNo { get; set; }
        /// <summary>
        /// 企业名称
        /// </summary>
        [Required(ErrorMessage = "企业名称必填")]
        public string enterpriseName { get; set; }
        /// <summary>
        /// 审批意见---1-->通过/0-->拒绝
        /// </summary>
        [Required(ErrorMessage = "审批意见必填")]
        public bool approvalOpinion { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string remarks { get; set; }


        /// <summary>
        /// 企业规模---大型/中型/小型
        /// </summary>
        public string enterpriseScale { get; set; }
        /// <summary>
        /// 划型企业---按照四部委标准定义
        /// </summary>
        public string planningEnterprise { get; set; }
        /// <summary>
        /// 营业收入
        /// </summary>
        public string businessIncome { get; set; }
        /// <summary>
        /// 从业人员
        /// </summary>
        public string practitioners { get; set; }
        /// <summary>
        /// 资产总额
        /// </summary>
        public string totalAssets { get; set; }
        /// <summary>
        /// 企业以及关键人是否满足人行征信准入条件
        /// </summary>
        public string IsFitReq { get; set; }
        /// <summary>
        /// 企业消贷比(分值)
        /// </summary>
        public string proportion { get; set; }
        /// <summary>
        /// 企业未结清贷款余额（分值）
        /// </summary>
        public string loanBalance { get; set; }
        /// <summary>
        /// 企业法定代表人最近24个自然月最高连续逾期次数
        /// </summary>
        public string overdueFrequency { get; set; }
        /// <summary>
        /// 企业法定代表人最近24个自然月累计逾期次数
        /// </summary>
        public string overdueTotalFrequency { get; set; }

    }
}
