using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;


namespace Reflect
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取一个类型的Type
            //1:当有这个类型的对象的时候
            //MyClass classes = new MyClass();
            //Type class_type = classes.GetType();
            //Console.WriteLine("该类型名称是：" + class_type.Name);
            ////2:当没有该类型的对象时---通过typeof()获取
            //Type T = typeof(MyClass);
            //Console.WriteLine("该类型名称是：" + T.Name);

            //Console.WriteLine("该类型的命名空间是{0},程序集dll是{1}", T.Namespace, T.Module);

            ////获取到type之后能干什么？
            ////1:获取该类型的父类
            //Type parent = T.BaseType;
            //Console.WriteLine(T.Name + "的父类名称是{0}", parent.Name);
            ////2:获取该类型中的所有字段
            //FieldInfo[] fields = T.GetFields();   //所有公共字段public修饰的字段
            //foreach (FieldInfo info in fields)
            //{
            //    Console.WriteLine(info.Name);
            //}
            ////3:获取该类型的所有属性
            //PropertyInfo[] pinfo = T.GetProperties();
            //foreach (PropertyInfo info in pinfo)
            //{
            //    Console.WriteLine("该属性的名称是{0},类型是{1}", info.Name, info.PropertyType.Name);
            //}


            //反射，动态加载程序集，获取类型，创建对象，并调用成员
            //反射需要使用Type类，（Type类是.NET分装好的类库,是抽象类）
            #region
            //1：获取一个类型的Type
            //Person po = new Person();
            //Type type = po.GetType();   //第一种获取方式（有类的对象）
            //Type ty = typeof(Person);   //第二种获取方式（没有创建对象时使用）
            //Console.WriteLine("{0},{1}", type, ty);
            //////2.1：获得类型之后就可以获取该类的父类
            //Type father = type.BaseType;
            //Console.WriteLine("该类的父类是：" + father);
            //////2.2:获取类的字段
            //FieldInfo[] fields = type.GetFields(); //此步骤需要using System.Reflection;
            //for (int i = 0; i < fields.Length; i++)
            //{
            //    //只能获取非私有字段(只能获取public修饰的字段,如果没有则为空)
            //    Console.WriteLine("字段：" + fields[i].Name);
            //}
            ////2.3:获取类的属性
            //PropertyInfo[] properties = type.GetProperties();
            //for (int j = 0; j < properties.Length; j++)
            //{
            //    Console.WriteLine("该属性名称{0},类型是{1}",properties[j].Name,properties[j].PropertyType);
            //}
            #endregion

            //动态加载程序集，并调用成员名称
            #region
            //1.0:加载程序集文件，返回程序集对象
            //一般情况下，先引用一个程序集才能调用该程序集中的成员（类或者其他），而使用反射就可以在不添加引用的前提下也可以获得程序集的引用
            //Assembly ass = Assembly.LoadFile(@"D:\VS\NET_BASE\Calculator\bin\Debug\Calculator.dll");  //获取文件程序集

            ////2.0：获取程序集中的所有类型(不管什么访问修饰符修饰的类，都可以获取)
            //Type[] types = ass.GetTypes();
            //for (int i = 0; i < types.Length; i++)
            //{
            //    Console.WriteLine(types[i].FullName);
            //}
            ////2.1:只获取访问修饰符是public修饰的类
            //Type[] ts = ass.GetExportedTypes();
            //for (int j = 0; j < ts.Length; j++)
            //{
            //    Console.WriteLine(ts[j].FullName);
            //}

            ////2.2:获取指定的类型
            ////Type asstype = ass.GetType();  //GetType的重载,获取程序集的类型
            //Type hello = ass.GetType("Calculator.TestHello");  //GetType重载，获取指定名称的类型

            ////2.2.1 第一种写法 无参数无返回值的方法
            //MethodInfo methed = hello.GetMethod("SayHi");  //获取类型中的“Jisuan”方法
            //object obhello = Activator.CreateInstance(hello);  //创建一个jiafa类型的对象，使用的是默认的构造函数（由于没有访问限制，所以不能new来创建）
            //methed.Invoke(obhello, null);  //调用“Jisuan”方法，第一个参数必须是该类型的一个对象

            ////2.2.2 第二种写法 有参数无返回值(SayHello函数是一个重载方法，如果调用没有参数的，则可以省略下面的第二个参数)
            //MethodInfo sayhello = hello.GetMethod("SayHello", new Type[] { typeof(string) });   //获取SayHello有参数的那个方法
            //sayhello.Invoke(Activator.CreateInstance(hello), new object[] { "这是一个参数" });

            ////2.2.3 有参数无返回值的
            //MethodInfo sayHelloHave = hello.GetMethod("Hello", new Type[] { typeof(string), typeof(string), typeof(int) });
            //object msg = sayHelloHave.Invoke(Activator.CreateInstance(hello), new object[] { "张三", "男", 19 });
            //Console.WriteLine(msg);

            ////3.0：根据类型创建对象
            //object myhello = Activator.CreateInstance(hello);   //创建一个类型的对象，使用的是类型默认的构造函数
            ////使用有参数的构造函数创建对象并赋值
            //ConstructorInfo ci = hello.GetConstructor(new Type[] { typeof(string), typeof(string), typeof(int) });
            //object omsg = ci.Invoke(new object[] { "李四", "男", 23 });
            ////通过反射获取对象的属性值
            //PropertyInfo pro_name = hello.GetProperty("Name");  //获取属性
            //string name = pro_name.GetValue(omsg, null).ToString();
            //Console.WriteLine(name);  //李四

            //Console.WriteLine("===华丽的分割线===");
            #endregion

            #region Test--方法
            ////-------------无参数的SayHello方法-----------------
            ////获取程序集对象assy
            ////Assembly ass = Assembly.Load("");
            //Assembly assy = Assembly.LoadFile(@"D:\VS\NET_BASE\Calculator\bin\Debug\Calculator.dll");
            ////获取程序集中的对象类型
            //Type testhello = assy.GetType("Calculator.TestHello");

            ////获取对象类型中的方法
            //MethodInfo info = testhello.GetMethod("SayHello", new Type[] { });  //因为SayHello方法出现了重载,所以必须定义参数数量Type
            ////创建类型的对象实例
            //object test = Activator.CreateInstance(testhello);
            ////通过Invoke调用方法
            //info.Invoke(test, new object[] { });

            /////------------有参数的SayHello方法--------------
            //MethodInfo sayH = testhello.GetMethod("SayHello", new Type[] { typeof(string) });
            ////创建一个类型的对象
            //object obj = Activator.CreateInstance(testhello);
            ////调用有参数(无返回值)的方法
            //sayH.Invoke(obj, new object[] { "昨夜西风凋碧树" });

            ////------------有返回值的方法Say方法--------------
            //MethodInfo say = testhello.GetMethod("Say", new Type[] { typeof(string) });
            //object o = Activator.CreateInstance(testhello);
            //object msg = say.Invoke(o, new object[] { "窗前明月光,疑是地上霜" });
            //Console.WriteLine(msg.ToString());
            #endregion

            #region 反射练习1
            //Assembly Calculator = Assembly.LoadFile(@"D:\VS\NET_BASE\Calculator\bin\Debug\Calculator.dll");  //1:获取程序集
            //Type[] memberTypes = Calculator.GetTypes();  //获取程序集中的所有类型(类、接口或者其他)
            //for (int k = 0; k < memberTypes.Length; k++)
            //{
            //    if (memberTypes[k].Name == "TestHello")   //判断类型名称
            //    {
            //        Type TestHello = Calculator.GetType("Calculator" + "." + memberTypes[k].Name);  //获取“Calculator.TestHello”类型
            //        MethodInfo[] methods = TestHello.GetMethods();  //通过类型名称获取所有方法
            //        for (int h = 0; h < methods.Length; h++)
            //        {
            //            if (methods[h].Name.ToLower() == "sayhi")  //判断方法名称SayHi
            //            {
            //                MethodInfo SayHi = TestHello.GetMethod(methods[h].Name);  //获取“SayHi”方法  
            //                object obj = Activator.CreateInstance(TestHello);  //创建类型对象(默认构造函数)
            //                SayHi.Invoke(obj, null);  //调用方法,无参数使用null代替
            //            }
            //            if (methods[h].Name.ToLower() == "hello")  //判断方法名称Hello
            //            {
            //                MethodInfo He = TestHello.GetMethod(methods[h].Name); //获取Hello方法
            //                object obj = Activator.CreateInstance(TestHello);  //创建类型对象(其他构造函数)

            //                ConstructorInfo coninfo = TestHello.GetConstructor(new Type[] { typeof(string), typeof(string), typeof(int) });
            //                object message = He.Invoke(obj, new object[] { "张三", "男", 23 });

            //                Console.WriteLine(message);
            //            }
            //        }
            //    }
            //}
            #endregion


            #region 反射练习2
            
            #endregion


            Console.ReadKey();
        }
    }

    //------------------类部分------------------
    //Person类
    public class Person
    {
        //构造函数重载
        public Person()
        { }
        public Person(string strname, string strsex, int intage)
        {
            this.Name = strname;
            this.Sex = strsex;
            this.Age = intage;
        }

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
        //重写Person的tostring()方法
        public override string ToString()
        {
            return this.Name + "," + this.Sex + "," + this.Age;
        }

        //定义一个方法
        public void SayHi()
        {
            Console.WriteLine("Hi...我是人类。。。");
        }
    }
    //Man类
    public class Man : Person
    {
        public Man()
        { }
        public Man(string name, string sex, int age)
            : base(name, sex, age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }


    }

}
