using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 单笔资金划拨小额鉴权请求类型
    /// </summary>
    public class AuthSmlAmtReq
    {
        /// <summary>
        /// 商户编号
        /// </summary>
        [Required(ErrorMessage = "商户编号必填")]
        public string mrchId { get; set; }
        /// <summary>
        /// 交易流水号
        /// </summary>
        [Required(ErrorMessage = "交易流水号必填")]
        public string tranSeqNo { get; set; }
        /// <summary>
        /// 商户日期时间
        /// </summary>
        [Required(ErrorMessage = "商户日期时间必填")]
        public string mrchDateTim { get; set; }
        /// <summary>
        /// 渠道标志
        /// </summary>
        [Required(ErrorMessage = "渠道标志必填")]
        public string channel { get; set; }
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
        /// 收款行行号
        /// </summary>
        public string payeeBranchId { get; set; }
        /// <summary>
        /// 收款行行名
        /// </summary>
        [Required(ErrorMessage = "收款行行名必填")]
        public string payeeBranchName { get; set; }
        /// <summary>
        /// 附言
        /// </summary>
        public string postscript { get; set; }
        ///// <summary>
        ///// 摘要
        ///// </summary>
        //public string abstract{ get; set; }

    }
}
