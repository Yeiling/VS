namespace shuiyintong.Entity.SPDBankEntity.SPDBankResp
{
    /// <summary>
    /// 借据应还本金利息查询返回类型
    /// </summary>
    public class CorpAgngLnRcvblntQryResp : BaseResp
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
        /// 借据号
        /// </summary>
        public string duebillNo { get; set; }
        /// <summary>
        /// 正常本金
        /// </summary>
        public string nrmlPrncpl { get; set; }
        /// <summary>
        /// 逾期本金
        /// </summary>
        public string oduePrncpl { get; set; }
        /// <summary>
        /// 应还本金利息
        /// </summary>
        public string interest { get; set; }
        /// <summary>
        /// 逾期本金利息
        /// </summary>
        public string oduePrncplInt { get; set; }
        /// <summary>
        /// 应还欠息
        /// </summary>
        public string onBalYrOweIntAmt { get; set; }
        /// <summary>
        /// 应还欠息利息
        /// </summary>
        public string onBalOweIntInt { get; set; }
        /// <summary>
        /// 应还复息
        /// </summary>
        public string offBalCmpdInt { get; set; }
        /// <summary>
        /// 应还复息利息
        /// </summary>
        public string offBalCmpdInts { get; set; }
        /// <summary>
        /// 贷款性质 0-正常 1-展期 2-一类逾期 3-二类逾期 4-呆滞 5-呆帐帐
        /// </summary>
        public string loanChartic { get; set; }

    }
}
