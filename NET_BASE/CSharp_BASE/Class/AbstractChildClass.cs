using System;

namespace CSharp_BASE.Class
{
    public class AbstractChildClass : AbstractPerentClass
    {
        //重写抽象类的属性
        public override string sex
        {
            get;
            set;
        }
        //重写抽象类的方法
        public override string SayHi() => "子类打招呼SAYHI";
        public override void SayHello() => Console.WriteLine("子类打招呼SAYHELLO");
    }
}
