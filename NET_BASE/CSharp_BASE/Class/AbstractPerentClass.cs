using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_BASE.Class
{
    public abstract class AbstractPerentClass
    {
        //抽象类中可以有实例成员，也可以由抽象成员
        private string _name;
        public abstract string sex
        {
            get;
            set;
        }
        //private abstract string _county;  //(abstract对于字段无效)
        //抽象方法不能有方法体（子类重写）
        public abstract string SayHi();
        public abstract void SayHello();
    }
}
