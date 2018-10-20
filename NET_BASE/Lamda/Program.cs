using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lamda
{
    class Program
    {
        public delegate void Get();  //无参数无返回值的委托
        public delegate string GetS(); //无参数有返回值的委托
        public delegate void GetSSS(int num); //有参数无返回值的委托
        public delegate string GetStr(string str);  //有参数和返回值的委托

        static void Main(string[] args)
        {
            //匿名方法不能在类中定义，而是给委托变量赋值时，需要赋值一个方法


            //1：匿名函数方式表达
            Get d = delegate() { };
            GetS de = delegate() { return "OOOOO"; };
            GetSSS del = delegate(int n) { };
            GetStr dell = delegate(string sys) { return sys; };

            //2：lamda表达式，本质上是一个匿名函数
            //lamda表达式参数不需要声明类型（也可以声明）
            Get g = () => { };    //无参数无返回值委托lamda表达式
            GetS gs = () => { return "饿了吗？？？"; }; //无参数有返回值的委托lamda表达式
            GetSSS gss = (a) => { }; //有参数无返回值的委托lamda表达式
            GetStr gts = (s) => { return s; }; //有参数和返回值的委托lamda表达式


            //Func<>是VS已经定义好的委托类型,【最后一个参数是返回值类型,前面是参数类型】
            //(1):委托写法
            Func<int, int, int> f1 = new Func<int, int, int>(Add);
            Program p = new Program();
            f1 += p.Add1;    //多播委托返回最后一个函数的返回值
            int e = f1(3, 4);

            Console.WriteLine(e);

            //(2):匿名委托的写法
            Func<int, int, int> f2 = delegate(int a, int b)
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

            //泛型委托有两个是VS集成的,Func<>和Action
            //Action是无返回值的泛型委托(可以有参数),Func<>是有参数有返回值的泛型委托


            //扩展方法
            //三要素:使用静态类,静态方法和this关键字




            Console.ReadKey();
        }

        //委托函数
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public int Add1(int a, int b)
        {
            return a - b;
        }

    }
}
