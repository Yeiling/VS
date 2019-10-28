using shuiyintong.Entity.SPDBankEntity.SPDBankResp;

namespace shuiyintong.Entity.SPDBankEntity.SPDResp
{
    /// <summary>
    /// 账户信息返回类型
    /// </summary>
    public class AccountResp: BaseResp
    {      
        /// <summary>
        /// 账号
        /// </summary>
        public string acctNo { get; set; }
        /// <summary>
        /// 货币代号
        /// </summary>
        public string currencyCode { get; set; }
        /// <summary>
        /// 客户中文名
        /// </summary>
        public string cifName { get; set; }
        /// <summary>
        /// 开户日期
        /// </summary>
        public string openDate { get; set; }
        /// <summary>
        /// 账户余额
        /// </summary>
        public string balance { get; set; }
        /// <summary>
        /// 营业机构号
        /// </summary>
        public string busDeptId { get; set; }

    }
}
