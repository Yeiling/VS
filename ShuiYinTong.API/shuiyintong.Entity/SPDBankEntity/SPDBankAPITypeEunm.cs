using System.ComponentModel;

namespace shuiyintong.Entity.SPDBankEntity
{
    public class SPDBankAPITypeEunm
    {
        public enum SPDBankAPIType
        {
            [Description("账户信息")]
            AccountInfo = 100,
            [Description("账户信息查询")]
            AcctDtlInfoQry = 101,
            [Description("单笔划拨")]
            SingleTransfer = 102,
            [Description("单笔划拨结果查询")]
            SnglTrsfRstlQry = 103,




        }
    }
}
