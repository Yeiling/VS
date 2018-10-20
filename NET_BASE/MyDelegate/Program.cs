using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDelegate
{
    //委托放在命名空间中，和类是平级的
    //委托是方法的模版,类似于定义一个抽象方法，使用关键字delegate声明
    public delegate string AddStr(string str1, string str2);    //有参数有返回值委托
    public delegate void Test();   //无参数无返回值委托

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
            string[] strs = new string[] { "sf", "ajoli", "tdj", "Wfsg", "dgd" };
            strs = StrSZ(strs, chageStrs);   //使用委托方法 chageStrs
            foreach (string s in strs)
            {
                Console.WriteLine(s);
            }
            strs = StrSZ(strs, otherchage);  //使用委托方法 otherchage
            foreach (string s in strs)
            {
                Console.WriteLine(s);
            }



            //使用委托 --- 实例2
            string[] sys = new string[] { "sf", "ajoli", "tdj", "Wfsg", "dgd" };
            sys = CaiStr(sys, changecai);
            foreach (string s in sys)
            {
                Console.WriteLine(s);
            }

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

        //定义委托实现方法
        public static string strcon(string s1, string s2)
        {
            return s1 + s2;
        }





    }
}
