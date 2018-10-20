using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reflect
{
    public class MyClass
    {
        private string _name;
        public string name
        {
            get;
            set;
        }
        public int _age;

        string Say(string msg)  //实例方法
        {
            if (string.IsNullOrEmpty(msg))
            {
                return string.Empty;
            }
            else
            {
                return msg;
            }
        }
        static void Hi(string msg)  //静态方法
        {
            Console.WriteLine(msg);
        }
    }
}
