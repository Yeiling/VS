﻿namespace CSharp_BASE.Class
{
    public class Person
    {
        public string name
        {
            get;
            set;
        }
        public string sex
        {
            get;
            set;
        }
        public int age
        {
            get;
            set;
        }

        public virtual string sayHi(string str) => str;
    }
}
