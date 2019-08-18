namespace Calculator
{
    public interface IJiSuanable
    {
        //接口里面可以包括属性、方法、索引器、事件；总归到底这些都是方法，不能有字段
        //接口与接口之间可以多继承（超级接口）

        //属性
        string Name
        {
            get;
            set;
        }
        //索引器
        string this[int index]
        {
            get;
            set;
        }


        //接口没有访问修饰符，默认是public，也没有方法体
        //方法
        void Isuan(double d1, double d2);
        double Ian(double d1, double d2);
        JiaFa IJia(JiaFa ji);

        //接口的实现不需要写override
    }
}
