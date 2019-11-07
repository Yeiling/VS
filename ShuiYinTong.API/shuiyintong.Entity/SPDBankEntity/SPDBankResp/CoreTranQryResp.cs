namespace shuiyintong.Entity.SPDBankEntity.SPDBankResp
{
    /// <summary>
    /// 还款查询返回类型
    /// </summary>
    public class CoreTranQryResp : BaseResp
    {
        /// <summary>
        /// 交易日期
        /// </summary>
        public string tranDate { get; set; }
        /// <summary>
        /// 柜员流水号
        /// </summary>
        public string hostSeqNo { get; set; }
        /// <summary>
        /// 前台日期
        /// </summary>
        public string frontendDate { get; set; }
        /// <summary>
        /// 前台流水号
        /// </summary>
        public string frontendSeqNo { get; set; }
        /// <summary>
        /// 记录状态
        /// </summary>
        public string recordStatus { get; set; }
        /// <summary>
        /// 是否标志
        /// </summary>
        public string isFlag { get; set; }

    }
}
