using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 电子回单申请请求类型
    /// </summary>
    public class ReceiptApplyReq
    {
        /// <summary>
        /// 平台号
        /// </summary>
        [Required(ErrorMessage = "平台号必填")]
        public string pltfrmNo { get; set; }
        /// <summary>
        /// 平台流水号
        /// </summary>
        [Required(ErrorMessage = "平台流水号必填")]
        public string pltfrmSeq { get; set; }
        /// <summary>
        /// 电子回单类型
        /// </summary>
        [Required(ErrorMessage = "电子回单类型必填")]
        public string rcpDgType { get; set; }
        /// <summary>
        /// 柜员流水号
        /// </summary>
        [Required(ErrorMessage = "柜员流水号必填")]
        public string tranSeqNo { get; set; }
        /// <summary>
        /// 客户号码
        /// </summary>
        [Required(ErrorMessage = "客户号码必填")]
        public string clientNo { get; set; }
        /// <summary>
        /// 客户账号
        /// </summary>
        [Required(ErrorMessage = "客户账号必填")]
        public string clientAcctNo { get; set; }
        /// <summary>
        /// 借据号
        /// </summary>
        public string duebillNo { get; set; }
        /// <summary>
        /// 起始日期
        /// </summary>
        [Required(ErrorMessage = "起始日期必填")]
        public string startDate { get; set; }
        /// <summary>
        /// 结束日期
        /// </summary>
        [Required(ErrorMessage = "结束日期必填")]
        public string endDate { get; set; }

    }
}
