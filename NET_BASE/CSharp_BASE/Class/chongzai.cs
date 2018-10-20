using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_BASE.Class
{
    public class chongzai
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //构造函数重载
        public chongzai()
        { }
        public chongzai(string name)
        {
            this.Name = name;
        }

        //方法的重载
        public static void M()
        { }
        public static void M(string s)
        { }
        public static void M(int i)
        { }
        public static void M(string s, int i)
        { }
        public static void M(int i, string s)
        { }
        public static void M(string s, string x)
        { }
        public static void M(int i, int j)
        { }

        //重载和有无返回值没有关系，只和方法名称和参数有关（类型和顺序）
        //static string M()  
        //{ }

    }
}
