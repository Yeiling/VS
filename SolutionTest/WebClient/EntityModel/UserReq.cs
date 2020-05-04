using System;
using System.ComponentModel.DataAnnotations;
using WebApiClient.DataAnnotations;
using WebClient.ValidationAttrExt;

namespace WebClient.EntityModel
{
    /// <summary>
    /// 用户参数请求示例
    /// </summary>
    public class UserReq
    {
        /// <summary>
        /// 账号必填，长度验证
        /// </summary>
        [Required]
        [StringLength(10, MinimumLength = 1)]
        public string Account { get; set; }

        /// <summary>
        /// 密码必填，长度验证
        /// </summary>
        [Required]
        [StringLength(10, MinimumLength = 6)]
        [AliasAs("a_password")] //// 别名
        public string Password { get; set; }

        /// <summary>
        /// 金额必填验证
        /// </summary>
        [Required]
        [Money(100, 10000)]
        public string UsedMonry { get; set; }

        /// <summary>
        /// 手机号码必填和规则验证
        /// </summary>
        [Required]
        [TellPhone]
        [DateTimeFormat("yyyy-MM-dd")] // 时间格式，优先级最高
        [IgnoreWhenNull] // 值为null则忽略序列化
        public string Phone { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [IgnoreSerialized] // 忽略序列化
        public string Note { get; set; }


        // 时间格式
        [DateTimeFormat("yyyy-MM-dd HH:mm:ss")]
        public DateTime DateTime { get; set; }
    }
}
