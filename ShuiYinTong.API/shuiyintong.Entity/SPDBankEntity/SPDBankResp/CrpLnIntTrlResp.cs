using System.Collections.Generic;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankResp
{
    /// <summary>
    /// 已放贷款还款计划查询返回类型
    /// </summary>
    public class CrpLnIntTrlResp : BaseResp
    {
        /// <summary>
        /// 借据号
        /// </summary>
        public string duebillNo { get; set; }
        /// <summary>
        /// 贷款余额
        /// </summary>
        public string loanBal { get; set; }
        /// <summary>
        /// 还款方式 1－等额本息还款（预留） 2－等额本金还款（预留） 3－到期一次还本 A－分期还款计划
        /// </summary>
        public string repayMode { get; set; }
        /// <summary>
        /// 利率
        /// </summary>
        public string execIntRate { get; set; }
        /// <summary>
        /// 应还利息总和
        /// </summary>
        public string repIntSum { get; set; }
        /// <summary>
        /// 还款明细
        /// </summary>
        public List<repayIntInfoItem> repayIntInfo { get; set; }
    }

    /// <summary>
    /// 还款对象
    /// </summary>
    public class repayIntInfoItem
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
        public string totalAmt { get; set; }

    }
}
