namespace shuiyintong.Entity.SPDBankEntity.SPDBankResp
{
    /// <summary>
    /// 贷款归还返回类型
    /// </summary>
    public class OlBrwLnRepyResp : BaseResp
    {
        /// <summary>
        /// 平台号
        /// </summary>
        public string pltfrmNo { get; set; }
        /// <summary>
        /// 平台流水号
        /// </summary>
        public string pltfrmSeq { get; set; }
        /// <summary>
        /// 借据号
        /// </summary>
        public string duebillNo { get; set; }
        /// <summary>
        /// 还款账号
        /// </summary>
        public string repayAcctNo { get; set; }
        /// <summary>
        /// 还本总额 小数点后保留两位有限数字.eg:100.00
        /// </summary>
        public string histOduePnpSmy { get; set; }
        /// <summary>
        /// 还息总额 小数点后保留两位有限数字.eg:100.00
        /// </summary>
        public string corpLnIntIncm { get; set; }
        /// <summary>
        /// 交易时间 HH:MM:SS
        /// </summary>
        public string tranTime { get; set; }
        /// <summary>
        /// 核心柜员流水号
        /// </summary>
        public string hostSeqNo { get; set; }
        /// <summary>
        /// 核心交易日期 YYYMMDD
        /// </summary>
        public string tranDate { get; set; }

    }
}
