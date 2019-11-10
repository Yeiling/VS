using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.SPDBankEntity.SPDBankReq
{
    /// <summary>
    /// 收款人白名单查询请求类型
    /// </summary>
    public class PayeeWhtLstQryReq
    {
        /// <summary>
        /// 三方签约账号
        /// </summary>
        [Required(ErrorMessage = "三方签约账号必填")]
        public string acctNo { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [Required(ErrorMessage = "状态必填")]
        public string acctNoStatus { get; set; }
        /// <summary>
        /// 起始笔数
        /// </summary>
        [Required(ErrorMessage = "起始笔数必填")]
        public string startNum { get; set; }

    }
}
