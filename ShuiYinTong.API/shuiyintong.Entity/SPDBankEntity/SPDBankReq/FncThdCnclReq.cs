using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 三方解约请求类型
    /// </summary>
    public class FncThdCnclReq
    {
        /// <summary>
        /// 客户号
        /// </summary>
        [Required(ErrorMessage = "客户号必填")]
        public string clientNo { get; set; }
        /// <summary>
        /// 签约账号
        /// </summary>
        [Required(ErrorMessage = "签约账号必填")]
        public string signAcctNo { get; set; }
        /// <summary>
        /// 审批核心企业账号
        /// </summary>
        [Required(ErrorMessage = "审批核心企业账号必填")]
        public string aprCrEpClntAtNo { get; set; }
        /// <summary>
        /// 审批核心企业中文名
        /// </summary>
        [Required(ErrorMessage = "审批核心企业中文名必填")]
        public string aprCrEpCltChsNm { get; set; }

    }
}
