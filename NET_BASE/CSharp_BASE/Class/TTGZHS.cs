using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_BASE.Class
{
    public class TTGZHS
    {
        //构造函数重载(四个)
        public TTGZHS()
        {
        }
        //使用this调用构造函数
        public TTGZHS(string name, int age)
            : this(name, "0", age)
        {
            //this.Name = name;
            //this.Age = age;
        }
        public TTGZHS(string name, string sex, int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }
        //字段和属性
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



    }
}
