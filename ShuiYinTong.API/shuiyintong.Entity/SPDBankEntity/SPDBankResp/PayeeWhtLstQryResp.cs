using System.Collections.Generic;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankResp
{
    /// <summary>
    /// 收款人白名单查询返回类型
    /// </summary>
    public class PayeeWhtLstQryResp : BaseResp
    {
        /// <summary>
        /// 三方签约账号
        /// </summary>
        public string acctNo { get; set; }
        /// <summary>
        /// 收款人白名单信息集合
        /// </summary>
        public List<payeeWhtLstInfoItem> payeeWhtLstInfo { get; set; }
    }

    /// <summary>
    /// 收款人白名单
    /// </summary>
    public class payeeWhtLstInfoItem
    {
        /// <summary>
        /// 商号编户
        /// </summary>
        public string mrchId { get; set; }
        /// <summary>
        /// 白名单编号
        /// </summary>
        public string spclListNo { get; set; }
        /// <summary>
        /// 入金账号类型 1-行内   2-行外
        /// </summary>
        public string acctNoType { get; set; }
        /// <summary>
        /// 入金账号
        /// </summary>
        public string pyAcctNo { get; set; }
        /// <summary>
        /// 入金账号名
        /// </summary>
        public string pyeAcctNm { get; set; }
        /// <summary>
        /// 状态 1-生效   2-失效
        /// </summary>
        public string acctNoStatus { get; set; }
        /// <summary>
        /// 生效时间
        /// </summary>
        public string effectTimes { get; set; }
        /// <summary>
        /// 失效时间
        /// </summary>
        public string losEffectTimeps { get; set; }

    }
}
