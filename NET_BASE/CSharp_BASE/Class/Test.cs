namespace CSharp_BASE.Class
{
    public static class Test
    {
        static int num;  //在类中声明的变量叫类的成员变量，可以不赋值，有默认值

        private static string _name;
        public static string Name
        {
            get { return _name; }
            set { _name = value; }
        }



    }
}
