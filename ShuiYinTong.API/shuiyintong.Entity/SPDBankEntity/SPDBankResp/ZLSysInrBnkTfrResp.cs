namespace shuiyintong.Entity.SPDBankEntity.SPDBankResp
{
    /// <summary>
    /// 备付金或结算户转客户结算户返回类型
    /// </summary>
    public class ZLSysInrBnkTfrResp : BaseResp
    {
        /// <summary>
        /// 平台号
        /// </summary>
        public string pltfrmNo { get; set; }
        /// <summary>
        /// 付款人账号
        /// </summary>
        public string spyrAcctNo { get; set; }
        /// <summary>
        /// 付款人名称
        /// </summary>
        public string spayerName { get; set; }
        /// <summary>
        /// 收款人账号
        /// </summary>
        public string spayeeAcctNo { get; set; }
        /// <summary>
        /// 收款人名称
        /// </summary>
        public string spayeeName { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public string stranAmt { get; set; }
        /// <summary>
        /// 交易摘要
        /// </summary>
        public string sabstractCode { get; set; }
        /// <summary>
        /// 核心柜员流水号
        /// </summary>
        public string shostSeqNo { get; set; }
        /// <summary>
        /// 核心交易日期
        /// </summary>
        public string stranDate { get; set; }

    }
}
