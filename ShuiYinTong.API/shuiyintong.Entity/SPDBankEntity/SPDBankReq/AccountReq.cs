using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 银行账户信息请求类型
    /// </summary>
    public class AccountReq
    {
        /// <summary>
        /// 账号
        /// </summary>
        [Required(ErrorMessage = "账号必填")]
        public string acctNo { get; set; }
    }
}
