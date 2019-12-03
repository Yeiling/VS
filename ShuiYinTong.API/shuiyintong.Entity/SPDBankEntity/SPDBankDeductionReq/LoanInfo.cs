using System;
using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankDeductionReq
{
    /// <summary>
    /// 银行放款信息请求类型
    /// </summary>
    public class LoanInfo
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
        /// 提款金额
        /// </summary>     
        [Required(ErrorMessage = "提款金额必填")]
        public string withdrawalAmount { get; set; }

        /// <summary>
        /// 提款日期
        /// </summary>     
        [Required(ErrorMessage = "提款日期必填")]
        public DateTime? withdrawalTime { get; set; }

        /// <summary>
        /// 提款账户账号
        /// </summary>    
        [Required(ErrorMessage = "提款账户账号必填")]
        public string acctNo { get; set; }

        /// <summary>
        /// 提款账户户名
        /// </summary>     
        [Required(ErrorMessage = "提款账户户名必填")]
        public string accountName { get; set; }

        /// <summary>
        /// 借款账户开户行
        /// </summary>   
        [Required(ErrorMessage = "借款账户开户行必填")]
        public string openBank { get; set; }

        /// <summary>
        /// 借款到期日
        /// </summary>        
        [Required(ErrorMessage = "借款到期日必填")]
        public DateTime? loanDueDate { get; set; }

        /// <summary>
        /// 资金用途
        /// </summary>  
        [Required(ErrorMessage = "资金用途必填")]
        public string proceUse { get; set; }

        /// <summary>
        /// 借款合同编号
        /// </summary>      
        [Required(ErrorMessage = "借款合同编号必填")]
        public string loanContractNo { get; set; }
    }
}
