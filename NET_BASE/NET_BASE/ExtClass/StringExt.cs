using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            int num = chr.Length / 2; //变量交换次数
            for (int i = 0; i < num; i++)
            {
                var c = chr[chr.Length - i - 1];
                chr[chr.Length - i - 1] = chr[i];
                chr[i] = c;
            }
            return chr.ToString();
        }
    }
}
