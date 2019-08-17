using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace ConsoleApplication
{
    class Program
    {
        public delegate string MyString(string s);  //定义一个委托类型

        public delegate int Arrmax(object o1, object o2);  //不使用泛型委托a
        public delegate T ArrMaxT<T>(T o1, T o2);  //使用泛型委托

        public delegate string wt(string name, int age, string sex);
        public delegate List<T> fxwt<T>(T t1, T t2);  //泛型委托 

        //委托事件的前提,事件本质上也是一种特殊的委托
        public event wt Event_wt;    //定义一个wt委托类型 的事件
        public event Action<string> Ac;  //定义一个无返回值,只有一个string类型参数的事件
        public event Func<string, string, string> Fn;  //定义一个有string返回值,且有两个string类型参数的事件

        static void Main(string[] args)
        {
            //Func<>是VS已经定义好的委托类型,最后一个参数是返回值类型,前面是参数类型
            //(1):委托写法
            Func<int, int, int> f1 = new Func<int, int, int>(Add);   //或者直接写Add
            Program p = new Program();
            f1 += p.Add1;    //多播委托返回最后一个函数的返回值
            int e = f1(3, 4);

            Console.WriteLine(e);

            //(2):匿名委托的写法
            Func<int, int, int> f2 = delegate (int a, int b)
            {
                return a + b;
            };
            int c = f2(3, 9);
            Console.WriteLine(c);

            //(3):lamda语句
            Func<int, int, int> f3 = (int a, int b) => { return a + b; };
            int h = f3(3, 1);
            Console.WriteLine(h);

            //(4):lamda表达式
            Func<int, int, int> f4 = (int a, int b) => a + b; ;
            int k = f3(3, 8);
            Console.WriteLine(k);

            //(5):再次简化
            Func<int, int, int> f5 = (a, b) => a + b; ;
            int v = f5(3, 5);
            Console.WriteLine(v);


            //(6):

            //泛型委托有两个是VS集成的,Func<>和Action
            //Action是无返回值的泛型委托(可以有参数),Func<>是有参数有返回值的泛型委托


            #region 委托简单例子
            //DoSomething ds = new DoSomething();
            //ds.IDO(Doing);

            //Console.WriteLine("**************");

            //DoOther d = new DoOther();
            //d.YouDO(Doing);
            #endregion

            //1:使用委托
            #region 委托
            //string[] str = { "AbcDefG", "HijKlMN", "opQRst", "UvwxYZ" };
            //StringWT(str, Upper);
            //StringWT(str, Lower);
            //StringWT(str, SHH);

            //for (int k = 0; k < str.Length; k++)
            //{
            //    Console.WriteLine("第" + (k + 1) + "个字符串是:{0}", str[k]);
            //}
            #endregion

            //2:匿名方法（当程序中委托是一个一次性解决一个问题的时候，可以使用匿名方法）
            #region 匿名函数（匿名方法）
            //StringWT(str, delegate(string s)   //使用匿名方法，直接将字符串转大写
            //{
            //    //return s.ToUpper();
            //    //return s.ToLower();
            //    return "\"" + s + "\"";

            //});
            //for (int k = 0; k < str.Length; k++)
            //{
            //    Console.WriteLine("第" + (k + 1) + "个字符串是:{0}", str[k]);
            //}
            #endregion

            //3:lamda表达式其实是匿名方法的一种简写  (=>意思是：goes to)
            #region lamda表达式，本质上是一个匿名函数
            //StringWT(str, (string s) => { return s.ToLower(); });
            //for (int k = 0; k < str.Length; k++)
            //{
            //    Console.WriteLine("第" + (k + 1) + "个字符串是:{0}", str[k]);
            //}
            #endregion


            //求任意数组的最大值
            //1：使用常规方法使用委托
            #region 匿名函数格式
            //object[] arr = { "hello", "wbjbj", "hwiu4hjueiuh", "太极张三丰" };
            //object o_max = GetMax(arr, delegate(object b1, object b2)
            //   {
            //       string max = (string)b1;   //此部分根据要计算的数组类型不同而不同
            //       string num = (string)b2;
            //       return max.Length - num.Length;
            //   });
            #endregion

            #region  lamda表达式格式
            //object o_max = GetMax(arr, (object o1, object o2) =>
            //{
            //    string max = (string)o1;   //此部分根据要计算的数组类型不同而不同
            //    string num = (string)o2;
            //    return max.Length - num.Length;
            //});
            //Console.WriteLine("The Max Num is {0}", o_max);
            #endregion

            //2：使用泛型委托
            #region  泛型委托
            //int[] arr = { 34, 56, 23, 9, 78, 10, 30, 1, 41 };
            //int max = GetMax<int>(arr, delegate(int nummax, int num)
            // {
            //     return nummax - num;
            // });
            //Console.WriteLine("最大值是：{0}", max);
            #endregion

            #region  lamda表达式
            //string[] strarr = { "fwbu", "hwifhihi", "hwgh", "d", "fw" };
            //string max_lenhgthstr = GetMax<string>(strarr, (string maxstr, string otherstr) =>
            //     {
            //         return maxstr.Length - otherstr.Length;
            //     });
            //Console.WriteLine("最长的字符串是:{0}", max_lenhgthstr);
            #endregion

            //多播委托，也叫委托链或者委托组合，即一个委托对象可以存储多个方法
            #region 多播委托--无参数无返回值
            //Action ac = M1;
            //ac();
            #endregion

            #region 多播委托--一个委托存储多个方法（这些方法的签名相同），统一传递一个参数
            //Action<string> actr = M2;  //一般第一个使用“=”赋值方法，其他使用“+=”
            //actr += M3;
            //actr += M4;
            //actr += M5;

            //actr -= M3;

            //actr("多播委托使用");  //输出三次
            #endregion

            //-----------------委托复习------------------
            #region
            //写法1 ---常规写法
            //wt w = new wt(GetMsg);
            //string msg = w("张三", 18, "男");
            //Console.WriteLine(msg);
            //写法2 ---lamda表达式
            //wt w1 = (name, age, sex) => { return name + "\n" + age + "\n" + sex; };
            //string str = w1("曹操", 98, "男");
            //Console.WriteLine(str);

            //泛型委托(返回值是泛型集合)
            //写法1   --常规委托写法
            //fxwt<string> fx = new fxwt<string>(Fx<string>);
            //List<string> lstr = fx("千山鸟飞绝", "万径人踪灭");
            //foreach (string s in lstr)
            //{
            //    Console.WriteLine(s);
            //}
            //写法2  --使用Lamda表达式
            //List<string> lstrs = new List<string>();
            //fxwt<string> fxstr = (str1, str2) =>
            //{
            //    lstrs.Add(str1);
            //    lstrs.Add(str2);
            //    return lstrs;
            //};
            //lstrs = fxstr("孤舟蓑笠翁", "独钓寒江雪");
            //for (int i = 0; i < lstrs.Count; i++)
            //{
            //    Console.WriteLine(lstrs[i].ToString());
            //}
            #endregion

            #region  ---系统提供的委托
            //Action:无返回值的委托,也可以使用Action<>的泛型委托
            //Func<>:有返回值的委托
            //(泛型委托,最后一个参数是返回值,前面的参数都是参数,如果泛型委托只有一个参数,那么该参数就是返回值)
            #endregion

            #region 委托作为参数--lamda表达式
            //string ss = TQ((a, b) => { return a.ToString() + b.ToString(); }, "你好,世界", "hello world");
            //Console.WriteLine(ss);
            ////TQ方法:
            ////static string TQ(Func<string, string, string> fn, string s1, string s2)
            ////{
            ////   return fn(s1, s2);
            ////}
            #endregion

            #region 委托作为返回值
            //Func<int, int, string> funs = QT();
            //string snum = funs(15, 12);
            //Console.WriteLine(snum);
            #endregion

            //事件，是一种特殊的委托
            #region 事件
            //// 实例化一个事件发送器
            //KeyInputMonitor monitor = new KeyInputMonitor();
            //// 实例化一个事件接收器
            //EventReceiver eventReceiver = new EventReceiver(monitor);
            //// 运行
            //monitor.Run();
            #endregion

            #region 泛型委托求数组最大值
            //int num = GetMax<int>(new int[] { 6, 3, 2, 0, 7, 10, 4 }, Add2);
            //Console.WriteLine(num);
            #endregion


            //同步委托和异步委托
            #region 同步调用委托(和调用一个方法一样,是同步调用委托)
            Func<int, int, string> fun = (a, b) => { return (a + b).ToString(); };
            string str = fun(2, 4);
            Console.WriteLine(str);

            Func<int, int, string> funs = wts;   //或者new Func<int, int, string>(wts);
            string str1 = funs(3, 6);
            Console.WriteLine(str1);
            #endregion

            #region 简单异步委托 内部原理:使用了线程池去执行了该方法
            IAsyncResult res = fun.BeginInvoke(5, 8, null, null);
            string sr = null;
            //if (res.IsCompleted)
            //{
            sr = fun.EndInvoke(res);  //EndInvoke方法可能会阻塞当前的主线程
            //}
            Console.WriteLine(sr);
            #endregion

            #region 带有回调函数的委托
            fun.BeginInvoke(4, 1, MyCallBack, "Hello World!!!");
            fun.BeginInvoke(4, 3, YouCallBack, fun);
            #endregion

            Console.ReadKey();
        }
        //定义两个异步委托回调函数
        public static void MyCallBack(IAsyncResult ar)  //异步委托回调函数
        {
            //A:第一种写法,回调函数是一个给定的字符串
            //1:拿到异步委托的执行结果
            AsyncResult IResult = ar as AsyncResult;    //将父类转换层子类类型,as如果转换失败,返回值是null
            if (IResult != null)
            {
                var del = (Func<int, int, string>)IResult.AsyncDelegate;  //del是fun.BeginInvoke()执行对象
                string str = del.EndInvoke(IResult);
                Console.WriteLine("返回结果是:" + str);
            }
            //2:拿到回调函数的参数"1234567890"
            object obj = IResult.AsyncState;
            Console.WriteLine("异步回调函数的参数是:" + obj.ToString());
        }
        public static void YouCallBack(IAsyncResult ar)  //异步委托回调函数
        {
            //B:第二种写法,回调函数是委托函数它本身,拿到返回值结果
            var velresult = (Func<int, int, string>)ar.AsyncState;
            string ss = velresult.EndInvoke(ar);
            Console.WriteLine("返回结果是:" + ss);
        }

        public static string wts(int a, int b)   //委托定义的方法
        {
            return (a + b).ToString();
        }
        /// <summary>
        /// 委托函数求和
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Add(int a, int b) => a + b;
        /// <summary>
        /// 非静态的方法
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Add1(int a, int b) => a - b;
        /// <summary>
        /// 静态的方法
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Add2(int a, int b) => a - b;


        //------------方法--------
        //定义一个方法
        #region 委托使用到的方法
        public static void Doing()
        {
            Console.WriteLine("8：30上班");
            Console.WriteLine("11：30午餐");
            Console.WriteLine("12：00午休");
            Console.WriteLine("13：00下午班");
        }
        #endregion
        //将字符串数组中的值转换成“大写”，“小写”，“添加双引号”
        static void StringWT(string[] arr, MyString ms)
        {
            for (int k = 0; k < arr.Length; k++)
            {
                arr[k] = ms(arr[k]);
            }
        }

        //转换成大写，小写，加双引号(委托的方法)
        #region 委托所使用的方法
        static string Upper(string s)
        {
            return s.ToUpper();
        }
        static string Lower(string s)
        {
            return s.ToLower();
        }
        static string SHH(string s)
        {
            return "\"" + s + "\"";
        }
        #endregion

        //求任意数组的最大值 (数组的类型没有限制)
        static object GetMax(object[] ob, Arrmax ar)
        {
            object max = ob[0];
            if (ob != null)
            {
                for (int i = 0; i < ob.Length; i++)
                {
                    if (ar(max, ob[i]) < 0)
                    {
                        max = ob[i];
                    }
                }
            }
            return max;
        }

        //泛型委托---(参数和返回值都是泛型类型)
        static T GetMax<T>(T[] arr, ArrMaxT<T> at)
        {
            T max = arr[0];
            if (arr != null && at != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (Convert.ToInt32(at(max, arr[i])) < 0)
                    {
                        max = arr[i];
                    }
                }

            }
            return max;
        }

        //多播委托使用到的方法
        #region
        static void M1()
        {
            Console.WriteLine("M1--多播委托");
        }

        static void M2(string msg)
        {
            Console.WriteLine(msg);
        }
        static void M3(string msg)
        {
            Console.WriteLine(msg);
        }
        static void M4(string msg)
        {
            Console.WriteLine(msg);
        }
        static void M5(string msg)
        {
            Console.WriteLine(msg);
        }
        #endregion


        static string GetMsg(string name, int age, string sex)
        {
            return name + "\n" + age + "\n" + sex;
        }
        //泛型委托
        static List<T> Fx<T>(T t1, T t2)
        {
            List<T> LT = new List<T>();
            LT.Add(t1);
            LT.Add(t2);
            return LT;
        }

        //将委托定义为参数
        static string TQ(Func<string, string, string> fn, string s1, string s2)
        {
            return fn(s1, s2);
        }
        //将委托定义为返回值
        static Func<int, int, string> QT()
        {
            return new Func<int, int, string>((a, b) => { return (a + b).ToString(); });
        }

    }


    //--------------------类部分------------------------
    //我们可以把事件编程简单地分成两个部分：事件发生的类（书面上叫事件发生器）和事件接收处理的类

    //----------------实现一个捕获键盘按键的程序---------

    //创建一个KeyEventArgs类
    public class KeyEventArgs
    {
        private char _keychar;
        public char keychar
        {
            get { return _keychar; }
        }

        public KeyEventArgs(char key_char)
            : base()
        {
            this._keychar = key_char;
        }

    }
    //创建事件发生类,用于监控键盘按键的输入并触发一个事件
    public class KeyInputMonitor
    {
        // 创建一个委托，返回类型为void，两个参数
        public delegate void keyHandle(object sender, KeyEventArgs e);
        // 将创建的委托和特定事件关联,在这里特定的事件为KeyDown
        public event keyHandle KeyDown;

        public void Run()
        {
            bool finished = true;
            while (finished)
            {
                Console.WriteLine("点击键盘输入:");
                string response = Console.ReadLine();
                char response_char = (string.IsNullOrEmpty(response) ? ' ' : char.ToUpper(response[0]));
                switch (response_char)
                {
                    case 'X':
                        finished = false;
                        break;
                    default:
                        // 得到按键信息的参数
                        KeyEventArgs keyEventArgs = new KeyEventArgs(response_char);
                        // 触发事件
                        KeyDown(this.GetType(), keyEventArgs);
                        break;
                        //KeyDown( this, KeyEventArgs );一句，这是触发事件的语句，并将事件交由KeyDownHandler这个委托来处理
                }
            }
        }

    }
    //创建一个事件的接收类
    public class EventReceiver
    {
        //构造函数
        public EventReceiver(KeyInputMonitor monitor)
        {
            // 产生一个委托实例并添加到KeyInputMonitor产生的事件列表中
            monitor.KeyDown += new KeyInputMonitor.keyHandle(this.OnkeyDown);
        }

        private void OnkeyDown(object obj, KeyEventArgs evt)
        {
            //真正的事件处理函数
            Console.WriteLine("触发事件是:{0},键盘值是:{1}", obj, evt.keychar);
        }
    }


}
