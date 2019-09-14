using System;

namespace ConsoleApplication.Class
{
    public class DoSomething
    {
        public void IDO(Del d)
        {
            Console.WriteLine("7：00起床");
            Console.WriteLine("7：30早餐");

            //Console.WriteLine("==========");
            d();
            //Console.WriteLine("==========");

            Console.WriteLine("17：30下班");
            Console.WriteLine("18：30晚餐");
            Console.WriteLine("21：30晚安");
        }
    }
    //委托是一种数据类型，所以是和类平级的
    public delegate void Del();
}
