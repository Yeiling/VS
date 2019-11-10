using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 退汇附加信息查询请求类型
    /// </summary>
    public class RexgAddInfoQryReq
    {
        /// <summary>
        /// 退汇业务编号
        /// </summary>
        [Required(ErrorMessage = "退汇业务编号必填")]
        public string withdrawBussId { get; set; }
    }
}
