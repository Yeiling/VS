using System;
using System.ComponentModel;
using System.Linq;

namespace shuiyintong.Common.Extend
{
    public static class EnumExt
    {
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
