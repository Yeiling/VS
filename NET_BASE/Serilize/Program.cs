using System;

namespace Serilize
{
    class Program
    {
        static void Main(string[] args)
        {
            //序列化和反序列化
            Human h1 = new Human("大伟", "男", 26);

            //1:Json序列化
            //

            //2:XML序列化


            //3:二进制序列化


            Console.ReadKey();
        }
    }


    //--------定义一个类-------
    public class Human
    {
        public string Name { get; set; }

        public string Sex { get; set; }

        public int Age { get; set; }
        //构造函数
        public Human()
        { }
        public Human(string name, string sex, int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }
    }

}
