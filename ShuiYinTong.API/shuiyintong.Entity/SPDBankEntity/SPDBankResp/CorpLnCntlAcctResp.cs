using System;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankResp
{
    /// <summary>
    /// 对公贷款还款维护返回类型
    /// </summary>
    public class CorpLnCntlAcctResp : BaseResp
    {
        /// <summary>
        /// 入账标志
        /// </summary>
        public string creditedFlag { get; set; }
        /// <summary>
        /// 柜员流水号
        /// </summary>
        public string hostSeqNo { get; set; }
        /// <summary>
        /// 交易日期
        /// </summary>
        public DateTime tranDate { get; set; }
        /// <summary>
        /// 借据号
        /// </summary>
        public string duebillNo { get; set; }
        /// <summary>
        /// 付款单位还款账号
        /// </summary>
        public string pymtUntRpyAcctNo { get; set; }
        /// <summary>
        /// 还本总额
        /// </summary>
        public string histOduePnpSmy { get; set; }
        /// <summary>
        /// 还息总额
        /// </summary>
        public string corpLnIntIncm { get; set; }

    }
}
