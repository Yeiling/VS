using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NET_BASE.Class
{
    public class Car : IHunmanable
    {
        public string SayHello(string name, string sex, int age)
        {
            return "汽车打招呼";
        }

        public void Run()
        {
            Console.WriteLine("汽车会跑！！！");
        }
    }
}
