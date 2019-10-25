using System.Collections.Generic;

namespace shuiyintong.Entity.SPDBankEntity.SPDResp
{
    /// <summary>
    /// 账户信息查询请求参数对象
    /// </summary>
    public class AcctDtlInfoQryResp
    {
        /// <summary>
        /// 返回信息
        /// </summary>
        public string statusMsg { get; set; }
        /// <summary>
        /// 返回状态码
        /// </summary>
        public string statusCode { get; set; }
        /// <summary>
        /// 交易流水号
        /// </summary>
        public string transNo { get; set; }
        /// <summary>
        /// 笔数
        /// </summary>
        public string totalCount { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        public string acctNo { get; set; }
        /// <summary>
        /// 货币代号
        /// </summary>
        public string currencyCode { get; set; }
        /// <summary>
        /// 客户中文名
        /// </summary>
        public string cifName { get; set; }
        /// <summary>
        /// 详细信息数组
        /// </summary>
        public List<detailQryArrayItem> detailQryArray { get; set; }

    }

    /// <summary>
    /// 详情信息
    /// </summary>
    public class detailQryArrayItem
    {
        /// <summary>
        /// 交易日期
        /// </summary>
        public string transDate { get; set; }
        /// <summary>
        /// 交易时间
        /// </summary>
        public string transTime { get; set; }
        /// <summary>
        /// 借贷标记
        /// </summary>
        public string dcFlag { get; set; }
        /// <summary>
        /// 交易金额
        /// </summary>
        public string transAmt { get; set; }
        /// <summary>
        /// 账户余额
        /// </summary>
        public string balance { get; set; }
        /// <summary>
        /// 摘要代码
        /// </summary>
        public string digestCode { get; set; }
        /// <summary>
        /// 柜员流水号
        /// </summary>
        public string tellerSeqno { get; set; }
        /// <summary>
        /// 传票组内序号
        /// </summary>
        public string txnSeqNo { get; set; }
    }
}
