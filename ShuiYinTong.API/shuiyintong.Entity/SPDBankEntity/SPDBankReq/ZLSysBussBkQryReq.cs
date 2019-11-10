using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 划拨结果查询请求类型
    /// </summary>
    public class ZLSysBussBkQryReq
    {
        /// <summary>
        /// 电子凭证号
        /// </summary>
        [Required(ErrorMessage = "电子凭证号必填")]
        public string realVchrNo { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        [Required(ErrorMessage = "账号必填")]
        public string acctNo { get; set; }
        /// <summary>
        /// 查询的笔数
        /// </summary>
        [Required(ErrorMessage = "查询的笔数必填")]
        public string queryNum { get; set; }
        /// <summary>
        /// 查询的起始笔数
        /// </summary>
        [Required(ErrorMessage = "查询的起始笔数必填")]
        public string startNum { get; set; }

    }
}
