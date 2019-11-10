using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 贷款还款明细查询请求类型
    /// </summary>
    public class IntDtlQryReq
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
        /// <summary>
        /// 起始笔数
        /// </summary>
        [Required(ErrorMessage = "起始笔数必填")]
        public string startNum { get; set; }
        /// <summary>
        /// 查询笔数
        /// </summary>
        [Required(ErrorMessage = "查询笔数必填")]
        public string queryNum { get; set; }
        /// <summary>
        /// 起始日期
        /// </summary>
        public string startDate { get; set; }
        /// <summary>
        /// 终止日期
        /// </summary>
        public string endDate { get; set; }

    }
}
