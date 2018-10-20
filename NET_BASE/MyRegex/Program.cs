using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MyRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            //正则表达式
            bool b;

            // . 匹配除了换行符\n以外的任意单一字符
            #region  .单一字符
            //while (true)
            //{
            //    Console.WriteLine("单一字符匹配，请输入字符：");
            //    string str = Console.ReadLine();
            //    b = Regex.IsMatch(str, "a.b");  //字母a和b之间只能有一个字符
            //    if (b)
            //    {
            //        Console.WriteLine("符合");
            //    }
            //    else
            //    {
            //        Console.WriteLine("不符合");
            //    }
            //}
            #endregion

            //[]匹配字符组中的一个
            #region []字符组
            //while (true)
            //{
            //    Console.WriteLine("[]字符匹配，请输入字符：");
            //    string str = Console.ReadLine();
            //    b = Regex.IsMatch(str, "a[a-zA-Z0-9]b");  //字母a和b之间只能有一个字符
            //    if (b)
            //    {
            //        Console.WriteLine("符合");
            //    }
            //    else
            //    {
            //        Console.WriteLine("不符合");
            //    }
            //}
            #endregion

            //贪婪模式（.+）和非贪婪模式（.+?）
            #region  贪婪模式和非贪婪模式
            //string ss = "1111,,,1,111,11111,,,";

            //Match m = Regex.Match(ss, ".+");
            //Console.WriteLine(m.Value);

            //Match mc = Regex.Match(ss, ".+?");
            //Console.WriteLine(mc.Value);
            #endregion

            #region
            #endregion



            #region IsMatch()方法匹配
            //while (true)
            //{
            //    Console.WriteLine("请输入汉字，否则不合法：");
            //    string email = Console.ReadLine();
            //    bool bools = Regex.IsMatch(email.Trim(), "^[\\u4e00-\\u9fa5]{0,}$", RegexOptions.IgnoreCase);

            //    if (bools)
            //    {
            //        Console.WriteLine("合法");
            //    }
            //    else
            //    {
            //        Console.WriteLine("不合法");
            //    }

            //}
            #endregion

            #region 字符串提取内容
            //string str = "i你好sa 9f 分hisi#@y78s7ysy ts7 2402ysi*hs+f";
            //MatchCollection mc = Regex.Matches(str, "[0-9]");
            //for (int i = 0; i < mc.Count; i++)
            //{
            //    Console.WriteLine(mc[i]);
            //}
            //Console.WriteLine("======");
            //foreach (Match m in mc)
            //{
            //    Console.WriteLine(m.Value);
            //}
            #endregion


            Console.ReadKey();
        }
    }
}
