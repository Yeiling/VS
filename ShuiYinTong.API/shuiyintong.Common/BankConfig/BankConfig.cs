﻿namespace shuiyintong.Common.BankConfig
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
        public string AcctInfoQry { get; set; }
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

    }
}
