namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 贷款试算请求类型
    /// </summary>
    public class InterestTrialReq
    {
        /// <summary>
        /// 起息日---必填项
        /// </summary>
        public string dstrDt { get; set; }
        /// <summary>
        /// 到期日---必填项
        /// </summary>
        public string expiredDate { get; set; }
        /// <summary>
        /// 贷款金额---必填项
        /// </summary>
        public string anlDstrPyAmt { get; set; }
        /// <summary>
        /// 贷款利率---必填项
        /// </summary>
        public string execIntRate { get; set; }
        /// <summary>
        /// 还款方式---必填项
        /// </summary>
        public string repayMode { get; set; }
        /// <summary>
        /// 首次结息日期
        /// </summary>
        public string setlIntDt { get; set; }
        /// <summary>
        /// 起始笔数---必填项
        /// </summary>
        public string startNum { get; set; }
        /// <summary>
        /// 查询笔数---必填项
        /// </summary>
        public string queryNum { get; set; }

    }
}
