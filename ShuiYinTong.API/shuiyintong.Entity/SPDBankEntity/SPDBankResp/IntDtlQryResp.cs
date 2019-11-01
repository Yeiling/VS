using System.Collections.Generic;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankResp
{
    /// <summary>
    /// 贷款还款明细查询返回类型
    /// </summary>
    public class IntDtlQryResp
    {
        /// <summary>
        /// 平台号
        /// </summary>
        public string pltfrmNo { get; set; }
        /// <summary>
        /// 客户号
        /// </summary>
        public string clientNo { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string clientName { get; set; }
        /// <summary>
        /// 借据号
        /// </summary>
        public string duebillNo { get; set; }
        /// <summary>
        /// 还款明细交易记录
        /// </summary>
        public List<tranIntInfoItem> tranIntInfo { get; set; }

    }

    /// <summary>
    /// 还款记录对象
    /// </summary>
    public class tranIntInfoItem
    {
        /// <summary>
        /// 交易日期
        /// </summary>
        public string intAcrlEndDt { get; set; }
        /// <summary>
        /// 实还本金
        /// </summary>
        public string repymtPrncpl { get; set; }
        /// <summary>
        /// 实还本金利息
        /// </summary>
        public string repymtIntAmt { get; set; }
        /// <summary>
        /// 实还表内欠息
        /// </summary>
        public string pdOwOnBalOwIntAmt { get; set; }
        /// <summary>
        /// 实还表内欠息利息
        /// </summary>
        public string pdOwOnBalOwIntIntAmt { get; set; }
        /// <summary>
        /// 实还表外欠息
        /// </summary>
        public string pOwOfBalOwIntAmt { get; set; }
        /// <summary>
        /// 实还表外欠息利息
        /// </summary>
        public string pdOwOfBalOwItItAmt { get; set; }
        /// <summary>
        /// 实还表外复息
        /// </summary>
        public string pdOwOfBalCmpdItAmt { get; set; }
        /// <summary>
        /// 实还表外复息利息
        /// </summary>
        public string pdOwOfBalCmpdItItAmt { get; set; }

    }
}
