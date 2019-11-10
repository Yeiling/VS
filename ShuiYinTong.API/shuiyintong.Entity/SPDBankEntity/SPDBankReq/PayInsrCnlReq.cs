using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 支付指令取消请求类型
    /// </summary>
    public class PayInsrCnlReq
    {
        /// <summary>
        /// 商户编号
        /// </summary>
        [Required(ErrorMessage = "商户编号必填")]
        public string mrchId { get; set; }
        /// <summary>
        /// 商户流水号
        /// </summary>
        [Required(ErrorMessage = "商户流水号必填")]
        public string mrchSeqNo { get; set; }
        /// <summary>
        /// 商户交易日期
        /// </summary>
        [Required(ErrorMessage = "商户交易日期必填")]
        public string tranDate { get; set; }
        /// <summary>
        /// 操作类型
        /// </summary>
        [Required(ErrorMessage = "操作类型必填")]
        public string oprlType { get; set; }

    }
}
