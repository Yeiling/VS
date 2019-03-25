using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDelegate
{
    //委托放在命名空间中，和类是平级的
    //委托是方法的模版,类似于定义一个抽象方法，使用关键字delegate声明
    public delegate string AddStr(string str1, string str2);//有参数返回值委托
    public delegate void Test(); //无参数无返回值委托

    public delegate string changestr(string s);
    public delegate string[] changesz(string[] strs);
    class Program
    {
        static void Main(string[] args)
        {
            //使用委托 1
            //AddStr add = new AddStr(strcon);
            //string str = add("hello", " world");
            //Console.WriteLine(str);

            //使用委托 2
            //AddStr adds = strcon;
            //string str1 = adds("你好", " 世界");
            //Console.WriteLine(str1);

            //使用委托 --- 实例1
            //string[] strs = new string[] { "sf", "ajoli", "tdj", "Wfsg", "dgd" };
            //strs = StrSZ(strs, chageStrs);   //使用委托方法 chageStrs
            //foreach (string s in strs)
            //{
            //    Console.WriteLine(s);
            //}
            //strs = StrSZ(strs, otherchage);  //使用委托方法 otherchage
            //foreach (string s in strs)
            //{
            //    Console.WriteLine(s);
            //}

            //使用委托 --- 实例2
            //string[] sys = new string[] { "sf", "ajoli", "tdj", "Wfsg", "dgd" };
            //sys = CaiStr(sys, changecai);
            //foreach (string s in sys)
            //{
            //    Console.WriteLine(s);
            //}

            #region 委托---字符串操作练习
            //string[] strArry = new string[] { "123", "23456", "1234" };
            //StrArryHelper(strArry, str =>
            //{
            //    return str.ToLower();
            //});
            //var result1 = GetMaxOrMin(strArry, (first, target) =>
            //{
            //    //return first.Length - target.Length; //最小长度
            //    return target.Length - first.Length; ////最大长度
            //}, out string maxOrMinlen);
            //int[] intArry = new int[] { 9, 1, 2, 10, 22, 1, 5, 7, 3, -4 };
            //var result2 = GetMaxOrMin(intArry, (first, target) =>
            //{
            //    //return first - target; //最小值
            //    return target - first; ////最大值
            //}, out int maxOrMin);
            #endregion

            #region 事件
            
            #endregion

            Console.ReadKey();
        }
        //定义一个方法，改变数组中每一个元素
        #region 第一个实例
        public static string[] StrSZ(string[] strs, changestr change)
        {
            for (int i = 0; i < strs.Length; i++)
            {
                strs[i] = change(strs[i]);
            }
            return strs;
        }
        public static string chageStrs(string str)
        {
            return str.ToUpper();
        }
        public static string otherchage(string str)
        {
            return "***" + str + "***";
        }
        #endregion
        #region 第二个实例
        public static string[] CaiStr(string[] ss, changesz sz)
        {
            return sz(ss);
        }
        public static string[] changecai(string[] sss)
        {
            for (int j = 0; j < sss.Length; j++)
            {
                sss[j] = "（" + sss[j] + "）";
            }
            return sss;
        }
        #endregion
        #region //定义委托实现方法
        public static string strcon(string s1, string s2)
        {
            return s1 + s2;
        }
        #endregion

        /// <summary>
        /// 字符串数组操作函数练习
        /// </summary>
        /// <param name="strArry"></param>
        /// <param name="strHandler"></param>
        /// <returns></returns>
        public static string[] StrArryHelper(string[] strArry, Func<string, string> strHandler)
        {
            for (int i = 0; i < strArry.Length; i++)
            {
                strArry[i] = strHandler(strArry[i]);
            }
            return strArry;
        }

        /// <summary>
        /// 委托求数组最大值
        /// </summary>
        /// <typeparam name="T">泛型类型<双击查看原图peparam>
        /// <param name="arry">数组</param>
        /// <param name="predit">比较委托函数</param>
        /// <returns></returns>
        public static T GetMaxOrMin<T>(T[] arry, Func<T, T, bool> predit)
        {
            T first = arry[0];
            for (int i = 0; i < arry.Length; i++)
            {
                if (!predit(first, arry[i]))
                    first = arry[i];
            }
            return first;
        }
        /// <summary>
        /// 求数组最大值，并统计个数
        /// </summary>
        /// <typeparam name="T">泛型类型<双击查看原图peparam>
        /// <param name="arry">数组</param>
        /// <param name="predit">比较委托函数</param>
        /// <param name="totalNum">计数</param>
        /// <returns></returns>
        public static Dictionary<T, int> GetMaxOrMin<T>(T[] arry, Func<T, T, int> predit, out T maxOrMin)
        {
            Dictionary<T, int> result = new Dictionary<T, int>();
            maxOrMin = arry[0];
            for (int i = 0; i < arry.Length; i++)
            {
                if (predit(maxOrMin, arry[i]) > 0)
                {
                    maxOrMin = arry[i];
                    if (!result.Keys.Contains(maxOrMin))
                        result.Add(maxOrMin, 1);
                    else
                        result[maxOrMin]++;
                }
                else if (predit(maxOrMin, arry[i]) <= 0)
                {
                    if (!result.Keys.Contains(arry[i]))
                        result.Add(arry[i], 1);
                    else
                        result[arry[i]]++;
                }
            }
            return result;
        }


    }
}
