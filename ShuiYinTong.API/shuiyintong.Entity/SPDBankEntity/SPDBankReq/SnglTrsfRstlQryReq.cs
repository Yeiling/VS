using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 单笔划拨接查询请求
    /// </summary>
    public class SnglTrsfRstlQryReq
    {
        /// <summary>
        /// 商户流水号
        /// </summary>
        [Required(ErrorMessage = "商户流水号必填")]
        public string merSeqno { get; set; }
        /// <summary>
        /// 付款人账号
        /// </summary>
        [Required(ErrorMessage = "付款人账号必填")]
        public string payAcct { get; set; }

    }
}
