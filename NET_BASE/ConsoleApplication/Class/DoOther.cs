using System;

namespace ConsoleApplication.Class
{
    public class DoOther
    {
        public void YouDO(Dell dl)
        {
            Console.WriteLine("5：00起床");
            Console.WriteLine("5：30早餐");

            //Console.WriteLine("==========");
            dl();
            //Console.WriteLine("==========");

            Console.WriteLine("17：00下班");
            Console.WriteLine("18：00晚餐");
            Console.WriteLine("21：00晚安");
        }
    }

    //委托是一种数据类型，所以是和类平级的
    public delegate void Dell();
}
