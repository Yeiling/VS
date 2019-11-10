using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 还款查询请求参数
    /// </summary>
    public class CoreTranQryReq
    {
        /// <summary>
        /// 前台日期
        /// </summary>
        [Required(ErrorMessage = "前台日期必填")]
        public string frontendDate { get; set; }
        /// <summary>
        /// 前台流水号
        /// </summary>
        [Required(ErrorMessage = "前台流水号必填")]
        public string frontendSeqNo { get; set; }

    }
}
