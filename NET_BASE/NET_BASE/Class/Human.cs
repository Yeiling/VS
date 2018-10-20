using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NET_BASE.Class
{
    [Serializable]       //添加[Serializable]标记,表示该类可以序列化，无法继承此类
    public class Human : IHunmanable
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _sex;

        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        //构造函数
        public Human()
        { }
        public Human(string name, string sex, int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }

        //接口实现
        public string SayHello(string name, string sex, int age)
        {
            return name + "\r\n" + sex + "\r\n" + age;
        }
        public void Run()
        {
            Console.WriteLine(this.Name + " 会奔跑！！！");
        }


        //父类封装接口的实现方法
        public static void Hun(IHunmanable ih)
        {
            ih.Run();
        }


    }
}
