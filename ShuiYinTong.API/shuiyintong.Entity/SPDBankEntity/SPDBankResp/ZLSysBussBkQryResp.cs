using System.Collections.Generic;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankResp
{
    /// <summary>
    /// 划拨结果查询返回类型
    /// </summary>
    public class ZLSysBussBkQryResp : BaseResp
    {
        /// <summary>
        /// 交易笔数
        /// </summary>
        public string tranNum { get; set; }
        /// <summary>
        /// 交易明细集合对象
        /// </summary>
        public List<bussBkInfoItem> bussBkInfo { get; set; }
    }
    /// <summary>
    /// 交易明细对象
    /// </summary>
    public class bussBkInfoItem
    {
        /// <summary>
        /// 交易流水编号
        /// </summary>
        public string tranSeqNo { get; set; }
        /// <summary>
        /// 付款人账号
        /// </summary>
        public string pyrAcctNo { get; set; }
        /// <summary>
        /// 付款人名称
        /// </summary>
        public string acctName { get; set; }
        /// <summary>
        /// 收款人账号
        /// </summary>
        public string payeeAcctNo { get; set; }
        /// <summary>
        /// 收款人名称
        /// </summary>
        public string payeeName { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public string tranAmt { get; set; }
        /// <summary>
        /// 交易摘要
        /// </summary>
        public string abstractCode { get; set; }
        /// <summary>
        /// 交易状态
        /// </summary>
        public string tranStatus { get; set; }
        /// <summary>
        /// 核心柜员流水号
        /// </summary>
        public string origHostSeqNo { get; set; }
        /// <summary>
        /// 核心交易日期
        /// </summary>
        public string tranDate { get; set; }

    }

}
