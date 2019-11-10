using System.Collections.Generic;
using System.Linq;

namespace shuiyintong.Common.Extend
{
    /// <summary>
    /// 集合类扩展
    /// </summary>
    public static class ArryExt
    {
        /// <summary>
        /// 集合是否可用
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lst"></param>
        /// <returns></returns>
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> lst) => lst != null && lst.Count() > 0;
    }
}
