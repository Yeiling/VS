using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PM.Common.Ext
{
    /// <summary>
    /// 扩展类
    /// </summary>
    public static class ListExt
    {
        /// <summary>
        /// 判断类型（集合）不可用
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lst">集合对象</param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> lst) => lst == null || lst.Count() == 0;
        /// <summary>
        /// 判断类型（集合）可用
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lst">集合对象</param>
        /// <returns></returns>
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> lst) => lst != null && lst.Count() > 0;
    }

}
