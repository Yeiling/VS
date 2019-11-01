namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 贷款还款明细查询请求类型
    /// </summary>
    public class IntDtlQryReq
    {
        /// <summary>
        /// 平台号---必填
        /// </summary>
        public string pltfrmNo { get; set; }
        /// <summary>
        /// 客户号---必填
        /// </summary>
        public string clientNo { get; set; }
        /// <summary>
        /// 借据号---必填
        /// </summary>
        public string duebillNo { get; set; }
        /// <summary>
        /// 起始笔数---必填
        /// </summary>
        public string startNum { get; set; }
        /// <summary>
        /// 查询笔数---必填
        /// </summary>
        public string queryNum { get; set; }
        /// <summary>
        /// 起始日期
        /// </summary>
        public string startDate { get; set; }
        /// <summary>
        /// 终止日期
        /// </summary>
        public string endDate { get; set; }

    }
}
