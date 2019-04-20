using System.Collections.Generic;
using System.Linq;

namespace NET_BASE.ExtClass
{
    /// <summary>
    /// 集合类扩展方法
    /// </summary>
    public static class ListExt
    {
        /// <summary>
        /// 集合扩展方法---判断是否为空
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="list">集合对象</param>
        /// <returns>是否为空</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> list) => list == null || list.Count() == 0;
        /// <summary>
        /// 集合扩展方法---判断是否为空
        /// </summary>
        /// <typeparam name="T泛型typeparam>
        /// <param name="list">集合对象</param>
        /// <returns>是否为空</returns>
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> list) => list != null && list.Count() > 0;

    }
}
