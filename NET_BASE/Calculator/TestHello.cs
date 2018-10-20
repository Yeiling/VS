using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class TestHello
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
        public TestHello() { }
        public TestHello(string name, string sex, int age)
        {
            this._name = name;
            this._sex = sex;
            this._age = age;
        }

        public void SayHi()
        {
            Console.WriteLine("Hi.....");
        }

        public void SayHello(string msg)
        {
            Console.WriteLine(msg);
        }
        public void SayHello()
        {
            Console.WriteLine("我是无参数无返回值的SayHello");
        }

        public string Say(string msg)
        {
            return msg;
        }
        public string Hello(string name, string sex, int age)
        {
            return name + "\r\n" + sex + " \r\n" + age;
        }

    }
}
