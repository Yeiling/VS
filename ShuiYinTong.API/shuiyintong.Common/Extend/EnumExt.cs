using System;
using System.ComponentModel;
using System.Linq;

namespace shuiyintong.Common.Extend
{
    /// <summary>
    /// 枚举扩展
    /// </summary>
    public static class EnumExt
    {
        /// <summary>
        /// 获取枚举描述信息
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string EnumToDesc(this Enum val)
        {
            var type = val.GetType();
            var memberInfo = type.GetMember(val.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes == null || attributes.Length != 1)
                return val.ToString();

            return (attributes.Single() as DescriptionAttribute).Description;
        }
    }
}
