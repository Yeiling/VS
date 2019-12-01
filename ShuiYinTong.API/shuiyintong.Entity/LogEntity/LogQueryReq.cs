using System;
using System.ComponentModel.DataAnnotations;

namespace shuiyintong.Entity.LogEntity
{
    /// <summary>
    /// 日志查询请求类型
    /// </summary>
    public class LogQueryReq
    {
        /// <summary>
        /// 日志状态(0---false---未处理 1---true---已处理)
        /// </summary>
        [Required(ErrorMessage = "日志状态码必填，默认为0--->false")]
        public bool? Status { get; set; }
        /// <summary>
        /// 银行名称
        /// </summary>
        public string BankName { get; set; }
        /// <summary>
        /// 控制器名称      
        /// </summary>
        public string CtrName { get; set; }
        /// <summary>
        /// Action名称    
        /// </summary>
        public string ActName { get; set; }
        /// <summary>
        /// 日期从
        /// </summary>
        [Required(ErrorMessage = "日期必填，默认为当天")]
        public DateTime? LoggedFrom { get; set; } = DateTime.Now;
        /// <summary>
        /// 日期到
        /// </summary>
        [Required(ErrorMessage = "日期必填，默认为当天")]
        public DateTime? LoggedEnd { get; set; } = DateTime.Now;
    }
}
