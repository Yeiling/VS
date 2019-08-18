using System;

namespace Calculator
{
    public class TestHello
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }

        //构造函数
        public TestHello() { }
        public TestHello(string name, string sex, int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }

        public void SayHi() => Console.WriteLine("Hi.....");

        public void SayHello(string msg) => Console.WriteLine(msg);
        public void SayHello() => Console.WriteLine("我是无参数无返回值的SayHello");

        public string Say(string msg) => msg;
        public string Hello(string name, string sex, int age) => name + "\r\n" + sex + " \r\n" + age;

    }
}
