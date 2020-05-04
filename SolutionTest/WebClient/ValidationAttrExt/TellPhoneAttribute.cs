using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace WebClient.ValidationAttrExt
{
    /// <summary>
    /// 手机号码验
    /// </summary>
    public class TellPhoneAttribute : ValidationAttribute
    {
        /// <summary>
        /// 构造
        /// </summary>
        public TellPhoneAttribute()
        { }

        /// <summary>
        /// 验证手机号码
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool IsValid(object value)
        {
            string phone = value.ToString();
            return string.IsNullOrWhiteSpace(phone) ? false : Regex.IsMatch(phone, @"^[1]+[3,5,6,7,8,9]+\d{9}");
        }

        /// <summary>
        /// 验证提示信息
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public override string FormatErrorMessage(string name) => $"手机号码无效！";

    }
}
