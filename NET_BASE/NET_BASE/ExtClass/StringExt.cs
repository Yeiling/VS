using System.Collections.Generic;
using System.Linq;

namespace NET_BASE.ExtClass
{
    /// <summary>
    /// 字符串（String）类扩展方法
    /// </summary>
    public static class StringExt
    {
        //扩展方法三要素：静态类，静态方法，this关键字
        /// <summary>
        /// 字符串截取
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="s">目标字符串</param>
        /// <param name="index">索引位置</param>
        /// <returns></returns>
        public static int GetStrIndex(this string str, string s, int index) => str.IndexOf(s, index);
        /// <summary>
        /// 判断集合中是否包含对象
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="list">集合对象</param>
        /// <param name="t">目标对象</param>
        /// <returns></returns>
        public static bool ContainKey<T>(this IEnumerable<T> list, T t)
        {
            if (list.Contains(t))
                return true;
            else
                return false;
        }
        /// <summary>
        /// 字符串反转
        /// </summary>
        /// <param name="str">目标字符串</param>
        /// <returns>返回值字符串</returns>
        public static string RevseseString(this string str)
        {
            char[] chr = str.ToCharArray();
            int num = chr.Length / 2; //变量交换次数
            char temp;
            for (int i = 0; i < num; i++)
            {
                temp = chr[chr.Length - i - 1];
                chr[chr.Length - i - 1] = chr[i];
                chr[i] = temp;
            }
            return chr.ToString();
        }


    }
}
