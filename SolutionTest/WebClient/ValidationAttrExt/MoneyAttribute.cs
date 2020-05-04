using System.ComponentModel.DataAnnotations;

namespace WebClient.ValidationAttrExt
{
    /// <summary>
    /// 金额参数验证扩展
    /// </summary>
    public class MoneyAttribute : ValidationAttribute
    {
        /// <summary>
        /// 最大金额
        /// </summary>
        public double Max { get; }
        /// <summary>
        /// 最小金额
        /// </summary>
        public double Min { get; }

        /// <summary>
        /// 参数传递
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public MoneyAttribute(double min, double max)
        {
            Max = max;
            Min = min;
        }

        /// <summary>
        /// 验证金额
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool IsValid(object value)
        {
            if (double.TryParse(value.ToString(), out double ValidValue))
                return (ValidValue >= Min && ValidValue <= Max) ? true : false;

            return false;
        }

        /// <summary>
        /// 金额验证失败错误信息提示
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public override string FormatErrorMessage(string name)
        {
            return $"金额验证失败，金额值不能小于{Min},且不能大于{Max}";
        }

    }
}
