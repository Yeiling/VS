using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 借据应还本金利息查询请求类型
    /// </summary>
    public class CorpAgngLnRcvblntQryReq
    {
        /// <summary>
        /// 平台号
        /// </summary>
        [Required(ErrorMessage = "平台号必填")]
        public string pltfrmNo { get; set; }
        /// <summary>
        /// 客户号
        /// </summary>
        [Required(ErrorMessage = "客户号必填")]
        public string clientNo { get; set; }
        /// <summary>
        /// 借据号
        /// </summary>
        [Required(ErrorMessage = "借据号必填")]
        public string duebillNo { get; set; }

    }
}
