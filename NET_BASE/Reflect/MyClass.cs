using System;

namespace Reflect
{
    public class MyClass
    {
        private string _name;
        public string Name
        {
            get;
            set;
        }
        public int _age;

        string Say(string msg)  //实例方法
        {
            if (string.IsNullOrEmpty(msg))
                return string.Empty;

            return msg;
        }
        //静态方法
        static void Hi(string msg) => Console.WriteLine(msg);

    }
}
