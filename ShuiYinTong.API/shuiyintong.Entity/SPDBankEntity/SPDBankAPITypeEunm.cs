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
            FncThdCncl = 105,
            /// <summary>
            /// 退汇附加信息查询
            /// </summary>
            [Description("退汇附加信息查询")]
            RexgAddInfoQry = 106,
            /// <summary>
            /// 根据抹账流水查原往账流水
            /// </summary>
            [Description("根据抹账流水查原往账流水")]
            BnkInfoQryCombntnTran = 107,
            /// <summary>
            /// 单笔资金划拨小额鉴权
            /// </summary>
            [Description("单笔资金划拨小额鉴权")]
            AuthSmlAmt = 108,
            /// <summary>
            /// 支付指令登记
            /// </summary>
            [Description("支付指令登记")]
            PayInsrChk = 109,
            /// <summary>
            /// 支付指令明细查询
            /// </summary>
            [Description("支付指令明细查询")]
            PayInsrDtlQry = 110,
            /// <summary>
            /// 支付指令取消
            /// </summary>
            [Description("支付指令取消")]
            PayInsrCnl = 111,
            /// <summary>
            /// 收款人白名单查询
            /// </summary>
            [Description("收款人白名单查询")]
            PayeeWhtLstQry = 112,
            /// <summary>
            /// 收款人白名单维护
            /// </summary>
            [Description("收款人白名单维护")]
            PayeeWhtLstMntn = 113,

        }
    }
}
