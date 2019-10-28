namespace shuiyintong.Common.BankConfig
{
    /// <summary>
    /// 银行配置类型
    /// </summary>
    public class BankConfig
    {
        public DBConfig DBConfig { get; set; }
        public SPDBankConfig SPDBankConfig { get; set; }

    }

    /// <summary>
    /// 数据库配置
    /// </summary>
    public class DBConfig
    {
        public string DBConn { get; set; }
        public string RedisConn { get; set; }
    }

    /// <summary>
    /// 浦发银行API参数配置
    /// </summary>
    public class SPDBankConfig
    {
        public string ClientId { get; set; }
        public string Secret { get; set; }

        /// <summary>
        /// 账户信息
        /// </summary>
        public string AcctInfo { get; set; }
        /// <summary>
        /// 账户信息查询
        /// </summary>
        public string AcctDtlInfoQry { get; set; }
        /// <summary>
        /// 单笔划拨
        /// </summary>
        public string SingleTransfer { get; set; }
        /// <summary>
        /// 单笔划拨结果
        /// </summary>
        public string SnglTrsfRstlQry { get; set; }
        /// <summary>
        /// 电子回单申请
        /// </summary>
        public string ElectRecptApplction { get; set; }
        /// <summary>
        /// 三方解约
        /// </summary>
        public string FncThdCncl { get; set; }
        /// <summary>
        /// 退汇附加信息查询
        /// </summary>
        public string RexgAddInfoQry { get; set; }
        /// <summary>
        /// 根据抹账流水查原往账流水
        /// </summary>
        public string BnkInfoQryCombntnTran { get; set; }
        /// <summary>
        /// 单笔资金划拨小额鉴权
        /// </summary>
        public string AuthSmlAmt { get; set; }
        /// <summary>
        /// 支付指令登记
        /// </summary>
        public string PayInsrChk { get; set; }


    }
}
