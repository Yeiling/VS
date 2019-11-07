namespace shuiyintong.Entity.SPDBankEntity.SPDBankResp
{
    /// <summary>
    /// 
    /// </summary>
    public class OlBrwLnRepyTrlResp : BaseResp
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
        /// 本金
        /// </summary>
        public string prncplBal { get; set; }
        /// <summary>
        /// 利息
        /// </summary>
        public string intBal { get; set; }
        /// <summary>
        /// 正常本金余额
        /// </summary>
        public string principal { get; set; }
        /// <summary>
        /// 偿还正常本金利息
        /// </summary>
        public string nrmPrncplInt { get; set; }
        /// <summary>
        /// 逾期本金
        /// </summary>
        public string oduePrncpl { get; set; }
        /// <summary>
        /// 逾期本金利息
        /// </summary>
        public string oduePrncplInt { get; set; }
        /// <summary>
        /// 表外复息偿还表外欠息金额
        /// </summary>
        public string offBalCmpdInt { get; set; }
        /// <summary>
        /// 表外复息利息
        /// </summary>
        public string offBalCmpdIntInt { get; set; }
        /// <summary>
        /// 表内欠息表内欠息利息金额
        /// </summary>
        public string onBalOweInt { get; set; }
        /// <summary>
        /// 表内欠息利息表内欠息
        /// </summary>
        public string onBalOweIntInt { get; set; }
        /// <summary>
        /// 表外欠息表外复息
        /// </summary>
        public string offBalOweInt { get; set; }
        /// <summary>
        /// 表外欠息利息表外复息利息金额
        /// </summary>
        public string offBalOweIntInt { get; set; }

    }
}
