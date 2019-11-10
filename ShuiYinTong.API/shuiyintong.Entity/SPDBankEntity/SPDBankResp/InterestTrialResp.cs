using System.Collections.Generic;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankResp
{
    /// <summary>
    /// 贷款试算返回类型
    /// </summary>
    public class InterestTrialResp : BaseResp
    {
        /// <summary>
        /// 贷款金额
        /// </summary>
        public string anlDstrPyAmt { get; set; }
        /// <summary>
        /// 结息周期
        /// </summary>
        public string intSetlPrd { get; set; }
        /// <summary>
        /// 利率
        /// </summary>
        public string execIntRate { get; set; }
        /// <summary>
        /// 应还利息总和
        /// </summary>
        public string totalInt { get; set; }
        /// <summary>
        /// 贷款试算详情集合
        /// </summary>
        public List<intTrialInfoItem> intTrialInfo { get; set; }

    }

    /// <summary>
    /// 贷款试算对象
    /// </summary>
    public class intTrialInfoItem
    {
        /// <summary>
        /// 还款日期
        /// </summary>
        public string repayDate { get; set; }
        /// <summary>
        /// 应还本金
        /// </summary>
        public string principal { get; set; }
        /// <summary>
        /// 应还利息
        /// </summary>
        public string interest { get; set; }

    }
}
