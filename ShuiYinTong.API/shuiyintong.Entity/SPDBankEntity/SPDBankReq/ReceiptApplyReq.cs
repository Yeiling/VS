namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 电子回单申请请求类型
    /// </summary>
    public class ReceiptApplyReq
    {
        /// <summary>
        /// 平台号---必填
        /// </summary>
        public string pltfrmNo { get; set; }
        /// <summary>
        /// 平台流水号---必填
        /// </summary>
        public string pltfrmSeq { get; set; }
        /// <summary>
        /// 电子回单类型---必填
        /// </summary>
        public string rcpDgType { get; set; }
        /// <summary>
        /// 柜员流水号---必填
        /// </summary>
        public string tranSeqNo { get; set; }
        /// <summary>
        /// 客户号码---必填
        /// </summary>
        public string clientNo { get; set; }
        /// <summary>
        /// 客户账号---必填
        /// </summary>
        public string clientAcctNo { get; set; }
        /// <summary>
        /// 借据号
        /// </summary>
        public string duebillNo { get; set; }
        /// <summary>
        /// 起始日期---必填
        /// </summary>
        public string startDate { get; set; }
        /// <summary>
        /// 结束日期---必填
        /// </summary>
        public string endDate { get; set; }

    }
}
