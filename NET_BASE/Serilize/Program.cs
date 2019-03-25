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
    }

}
