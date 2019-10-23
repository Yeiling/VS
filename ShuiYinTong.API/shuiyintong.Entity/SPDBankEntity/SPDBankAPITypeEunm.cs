using System.ComponentModel;

namespace shuiyintong.Entity.SPDBankEntity
{
    /// <summary>
    /// 浦发银行接口名称
    /// </summary>
    public class SPDBankAPITypeEunm
    {
        /// <summary>
        /// 接口类型
        /// </summary>
        public enum SPDBankAPIType
        {
            /// <summary>
            /// 账户信息接口
            /// </summary>
            [Description("账户信息")]
            AcctInfo = 100,
            /// <summary>
            /// 账户信息查询接口
            /// </summary>
            [Description("账户信息查询")]
            AcctDtlInfoQry = 101,
            /// <summary>
            /// 单笔划拨接口
            /// </summary>
            [Description("单笔划拨")]
            SingleTransfer = 102,
            /// <summary>
            /// 单笔划拨结果查询接口
            /// </summary>
            [Description("单笔划拨结果查询")]
            SnglTrsfRstlQry = 103,
            /// <summary>
            /// 电子回单申请接口
            /// </summary>
            [Description("电子回单申请")]
            ElectRecptApplction = 104,
            /// <summary>
            /// 三方解约
            /// </summary>
            [Description("三方解约")]
            FncThdCncl =105

        }
    }
}
