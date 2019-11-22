using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankDeductionReq
{
    /// <summary>
    /// 授信---退税核验请求类型
    /// </summary>
    public class TaxVerification
    {
        /// <summary>
        /// 平台项目编号
        /// </summary>
        [Required(ErrorMessage = "平台项目编号必填")]
        public string platformAcctNo { get; set; }
        /// <summary>
        /// 企业名称
        /// </summary>
        [Required(ErrorMessage = "企业名称必填")]
        public string enterpriseName { get; set; }
        /// <summary>
        /// 户名
        /// </summary>
        [Required(ErrorMessage = "户名必填")]
        public string accountName { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        [Required(ErrorMessage = "账号必填")]
        public string acctNo { get; set; }
        /// <summary>
        /// 开户行
        /// </summary>
        [Required(ErrorMessage = "开户行必填")]
        public string openBank { get; set; }
        /// <summary>
        /// 是否退税账户---(1:是 0：否)
        /// </summary>
        [Required(ErrorMessage = "是否退税账户必填")]
        public bool IsDrawback { get; set; }
    }
}
