using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_BASE.Class
{
    public class Employee : Person
    {
        //属性
        public string address
        {
            get;
            set;
        }

        //构造函数
        public Employee()
        { }
        //重载构造函数
        public Employee(string name, string sex, int age, string address)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;  //以上三个是父类的属性，之类可以使用

            this.address = address; //子类自己定义的属性
        }

        //重写父类的虚方法
        public override string sayHi(string str)
        {
            return base.sayHi(str);
        }

    }
}
