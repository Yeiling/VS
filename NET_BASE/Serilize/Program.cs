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
            Book b = new Book(1001, "百年孤独", (decimal)119.0, "马尔克斯", "这本书很有看点.....");

            //2:XML序列化


            //3:二进制序列化


            Console.ReadKey();
        }
    }


    //--------定义一个类-------
    /// <summary>
    /// Human类型
    /// </summary>
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

    /// <summary>
    /// Book结构
    /// </summary>
    public struct Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public decimal Price { get; set; }
        public string Athor { get; set; }
        public string Note { get; set; }

        public Book(int bookid, string bookname, decimal price, string athor, string note)
        {
            BookId = bookid;
            BookName = bookname;
            Price = price;
            Athor = athor;
            Note = note;
        }
    }

}
