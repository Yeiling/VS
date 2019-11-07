using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 根据抹账流水查原往账流水请求类型
    /// </summary>
    public class BnkInfoQryCombntnTranReq
    {
        /// <summary>
        /// 账号
        /// </summary>
        [Required(ErrorMessage = "账号必填")]
        public string acctNo { get; set; }
        /// <summary>
        /// 柜员流水号
        /// </summary>
        [Required(ErrorMessage = "柜员流水号必填")]
        public string hostSeqNo { get; set; }
        /// <summary>
        /// 交易日期
        /// </summary>
        [Required(ErrorMessage = "交易日期必填")]
        public string tranDate { get; set; }
        /// <summary>
        /// 传票组内序号
        /// </summary>
        [Required(ErrorMessage = "传票组内序号必填")]
        public string txnSeqNo { get; set; }

    }
}
