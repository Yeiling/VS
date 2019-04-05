using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NET_BASE.ExtClass
{
    public static class ExtendClass
    {
        //扩展方法三要素：静态类，静态方法，this关键字
        /// <summary>
        /// 字符串截取
        /// </summary>
        /// <param name="str"></param>
        /// <param name="s"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static int GetString(this string str, string s, int index)
        {
            return str.IndexOf(s, index);
        }
        public static bool GetString(this string[] strArry, string str)
        {
            if (strArry.Contains(str))
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

            int num = chr.Length / 2;
            for (int i = 0; i < num; i++)
            {
                var c = chr[chr.Length - i - 1];
                chr[chr.Length - i - 1] = chr[i];
                chr[i] = c;
            }
            return chr.ToString();
        }


        /// <summary>
        /// 集合扩展方法---判断是否为空
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="list">集合对象</param>
        /// <returns>是否为空</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> list)
        {
            return list == null || list.Count() == 0;
        }

    }
}
