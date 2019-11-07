using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 电子回单申请请求类型
    /// </summary>
    public class ElectRecptApplctionReq
    {
        /// <summary>
        /// 柜员流水号
        /// </summary>
        [Required(ErrorMessage = "柜员流水号必填")]
        public string tellerSeqno { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        [Required(ErrorMessage = "账号必填")]
        public string acctNo { get; set; }
        /// <summary>
        /// 核心日期
        /// </summary>
        [Required(ErrorMessage = "核心日期必填")]
        public string hostDate { get; set; }
        /// <summary>
        /// 电子邮件地址
        /// </summary>
        public string notifyEmail { get; set; }
        /// <summary>
        /// 传票组内序号
        /// </summary>
        [Required(ErrorMessage = "传票组内序号必填")]
        public string txnSeqNo { get; set; }

    }
}
