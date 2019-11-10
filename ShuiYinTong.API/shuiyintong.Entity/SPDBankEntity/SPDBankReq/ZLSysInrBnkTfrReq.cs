using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 备付金或结算户转客户结算户请求类型
    /// </summary>
    public class ZLSysInrBnkTfrReq
    {
        /// <summary>
        /// 平台号
        /// </summary>
        [Required(ErrorMessage = "平台号必填")]
        public string pltfrmNo { get; set; }
        /// <summary>
        /// 付款人账号
        /// </summary>
        [Required(ErrorMessage = "付款人账号必填")]
        public string pyrAcctNo { get; set; }
        /// <summary>
        /// 付款人名称
        /// </summary>
        [Required(ErrorMessage = "付款人名称必填")]
        public string payerName { get; set; }
        /// <summary>
        /// 收款人账号
        /// </summary>
        [Required(ErrorMessage = "收款人账号必填")]
        public string payeeAcctNo { get; set; }
        /// <summary>
        /// 收款人名称
        /// </summary>
        [Required(ErrorMessage = "收款人名称必填")]
        public string payeeName { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        [Required(ErrorMessage = "金额必填")]
        public decimal tranAmt { get; set; }
        /// <summary>
        /// 电子凭证号
        /// </summary>
        [Required(ErrorMessage = "电子凭证号必填")]
        public string realVchrNo { get; set; }
        /// <summary>
        /// 交易摘要
        /// </summary>
        public string abstractCode { get; set; }

    }
}
