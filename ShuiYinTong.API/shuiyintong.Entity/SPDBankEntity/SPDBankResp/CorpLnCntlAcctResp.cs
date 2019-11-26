using System;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankResp
{
    /// <summary>
    /// 对公贷款还款维护返回类型
    /// </summary>
    public class CorpLnCntlAcctResp : BaseResp
    {
        /// <summary>
        /// 入账标志 0-未入账 1-入账成功 2-入账失败 3-宕账
        /// </summary>
        public string creditedFlag { get; set; }
        /// <summary>
        /// 柜员流水号
        /// </summary>
        public string hostSeqNo { get; set; }
        /// <summary>
        /// 交易日期 YYYYMMDD
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
        /// 还本总额 小数点后保留两位有限数字.eg:100.00
        /// </summary>
        public string histOduePnpSmy { get; set; }
        /// <summary>
        /// 还息总额 小数点后保留两位有限数字.eg:100.00
        /// </summary>
        public string corpLnIntIncm { get; set; }

    }
}
