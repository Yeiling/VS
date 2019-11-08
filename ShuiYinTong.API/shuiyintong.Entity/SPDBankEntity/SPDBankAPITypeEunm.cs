using System.ComponentModel;

namespace shuiyintong.Entity.SPDBankEntity
{
    /// <summary>
    /// 浦发银行接口名称
    /// </summary>
    public class SPDBankAPITypeEunm
    {
        /// <summary>
        /// 浦发银行接口名称
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


            /// <summary>
            /// 备付金或结算户转客户结算户
            /// </summary>
            [Description("备付金或结算户转客户结算户")]
            ZLSysInrBnkTfr = 114,
            /// <summary>
            /// 贷款归还
            /// </summary>
            [Description("贷款归还")]
            OlBrwLnRepy = 115,
            /// <summary>
            /// 贷款还款明细查询
            /// </summary>
            [Description("贷款还款明细查询")]
            IntDtlQry = 116,
            /// <summary>
            /// 贷款试算
            /// </summary>
            [Description("贷款试算")]
            InterestTrial = 117,
            /// <summary>
            /// 电子回单申请
            /// </summary>
            [Description("电子回单申请")]
            ReceiptApply = 118,
            /// <summary>
            /// 对公贷款还款维护
            /// </summary>
            [Description("对公贷款还款维护")]
            CorpLnCntlAcctRep = 119,
            /// <summary>
            /// 归还贷款本金利息试算
            /// </summary>
            [Description("归还贷款本金利息试算")]
            OlBrwLnRepyTrl = 120,
            /// <summary>
            /// 还款查询
            /// </summary>
            [Description("还款查询")]
            CoreTranQry = 121,
            /// <summary>
            /// 划拨结果查询
            /// </summary>
            [Description("划拨结果查询")]
            ZLSysBussBkQry = 122,
            /// <summary>
            /// 借据详细信息查看
            /// </summary>
            [Description("借据详细信息查看")]
            LnRcrdDtlQry = 123,
            /// <summary>
            /// 借据应还本金利息查询
            /// </summary>
            [Description("借据应还本金利息查询")]
            CorpAgngLnRcvblntQry = 124,
            /// <summary>
            /// 已放贷款还款计划查询
            /// </summary>
            [Description("已放贷款还款计划查询")]
            CrpLnIntTrl = 125,
        }
    }
}
