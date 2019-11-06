using System;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankFile
{
    /// <summary>
    /// 生成担保函文档请求类型
    /// </summary>
    public class GuaranteeReq
    {
        /// <summary>
        ///借款企业 
        /// </summary>
        public string BorrowingEnterprise { get; set; }
        /// <summary>
        /// 借款合同编号
        /// </summary>
        public string AgreementNumber { get; set; }
        /// <summary>
        /// 借款金额
        /// </summary>
        public string Loan { get; set; }
        /// <summary>
        ///  担保的借款金额为人民币
        /// </summary>
        public string GuaranteedMount { get; set; }
        /// <summary>
        /// 申请借款的期限月
        /// </summary>
        public string PeriodMonth { get; set; }
        /// <summary>
        /// 起息日期
        /// </summary>
        public DateTime InterestDate { get; set; }
        /// <summary>
        /// 到期日期
        /// </summary>
        public DateTime DueDate { get; set; }
        /// <summary>
        /// 总金额
        /// </summary>
        public string TotalMoney { get; set; }
        /// <summary>
        /// 输出路径
        /// </summary>
        public string OutPath { get; set; }
    }
}
