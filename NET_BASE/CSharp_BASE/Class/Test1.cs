namespace CSharp_BASE.Class
{
    public class Test1 : chongzai
    {
        //静态类不能继承自其他静态类或者非静态类

        //静态类里面只能定义静态成员，非静态类可以定义静态成员和非静态成员
        private string _Tname;
        public string Tname
        {
            get { return _Tname; }
            set { _Tname = value; }
        }
        private string _Tsex;
        public string Tsex
        {
            get { return _Tsex; }
            set { _Tsex = value; }
        }
        //:base()  是调用父类的构造函数(多余的参数再直接写（如：Tsex）)
        //构造函数不能继承
        public Test1(string strname, string sex)
            : base(strname)
        {
            this.Tsex = sex;
        }
    }
}
