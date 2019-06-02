using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NET_BASE
{
    /// <summary>
    /// 定义一个带有参数和返回值的委托
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public delegate string MyDelehate(string s);
    /// <summary>
    /// 枚举定义
    /// </summary>
    public enum Sex
    {
        man,
        woman
    }
    class Program
    {
        /// <summary>
        /// 枚举数据类型
        ///枚举类型转换成整数类型是自动的，整数类型可以强制转换成枚举类型：weeks w=(weeks)3
        /// </summary>
        #region 枚举
        public enum Weeks
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday = 0
        }
        #endregion
        /// <summary>
        /// 定义结构
        /// 结构用来存放数据，可以包含构造函数、方法、事件、索引器，如果有多个构造法方法，事件等时，使用类来解决，同时，结构不具有面向对象的特征
        /// </summary>
        #region 结构
        public struct Cat
        {
            private string _name;
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            public double Weight;
            public string Color;
        }
        #endregion

        static void Main(string[] args)
        {
            #region 一元运算符
            //int a = 1, b = 0;
            //b = (a++) + (++a) + (--a) - (a--);
            //Console.WriteLine(b);  ////4
            #endregion

            //九九乘法表
            #region
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j + "*" + i + "=" + (i * j) + "    ");
            //    }
            //}
            #endregion

            //字符串
            #region
            //Console.WriteLine("请输入字符串！");
            //string s = Console.ReadLine();
            //string result = ClearNull(s);
            //Console.WriteLine("输入的字符:{0}---结果是:{1}", s, result);
            #endregion

            //数据类型
            //DataRange();

            //结构
            #region
            //Cat c = new Cat();
            //c.Name = "TomCat";
            //c.Weight = 10;
            //c.Color = "White";
            //Console.WriteLine("{0}==={1}==={2}", c.Name, c.Weight, c.Color);
            //Cat c1 = new Cat();
            //Console.WriteLine("{0}=={1}=={2}=={3}",c.Equals(c1),c.GetHashCode(),c.GetType(),c.ToString());
            #endregion

            //运算符(除数与被除数的关系)
            #region
            //int m = 55, n = 9;
            //Console.WriteLine(m/n);
            //double i = 3.14, j = 1.01;
            //Console.WriteLine(i/j);
            //int k = 8;
            //double h = 3.14;
            //Console.WriteLine(k/h);
            //Console.WriteLine(h/k);
            #endregion

            //++,--
            #region
            //int num1 = 9;
            //Console.WriteLine("{0}===={1}", num1, num1++);
            //int num2 = 1;
            //Console.WriteLine("{0}===={1}", num2, ++num2);
            //int num3 = 100;
            //Console.WriteLine("{0}===={1}", num3, num3--);
            //int num4 = 1000;
            //Console.WriteLine("{0}===={1}", num4, --num4);
            #endregion

            //位运算（<<和>>）
            #region
            //int arr = 16;
            //arr >>= 3;    //>> 除以2的个数  结果是：2
            //Console.WriteLine(arr);
            //arr <<= 4;    //<<乘以2的个数   结果是：32
            //Console.WriteLine(arr);
            #endregion

            //值传递和引用传递
            #region
            //int num = 6, refnum = 9;
            //TranPara(num, ref refnum);
            //Console.WriteLine("num is {0},refnum is {1}", num, refnum);

            //int[] arry = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int sum = Params(arry);
            //Console.WriteLine(sum);
            //Console.WriteLine(Params());
            #endregion

            //索引器
            #region
            //MyIndex m = new MyIndex();
            //m.AddString("零");
            //m.AddString("一");
            //m.AddString("二");
            //Console.WriteLine("[0]---{0}", m[0]);
            //Console.WriteLine("[1]---{0}", m[1]);
            //Console.WriteLine("[2]---{0}", m[2]);
            //Console.WriteLine("[3]---{0}", m[3]);

            //m[0] = "零零";
            //Console.WriteLine("[0]---{0}", m[0]);

            //m[3] = "三";
            //Console.WriteLine("[4]---{0}", m[3]);
            #endregion

            //泛型类与索引器
            #region
            //int sum = 0;
            //MyIndexF<string> my = new MyIndexF<string>();
            //for (int i = 0; i < 100; i++)
            //{
            //    my[i] = i.ToString();
            //    sum++;
            //}

            //for (int j = 0; j < sum; j++)
            //{
            //    string str = my[j];
            //    Console.WriteLine(str);
            //}
            #endregion

            //foreach，其实调用foreach遍历数据，调用的是一个枚举器，foreach只是语法上的一个简化

            //枚举器的使用
            #region  第一种方法：调用枚举器来遍历实现接口的类型
            //string[] ss = new string[] { "张三", "李四", "王五", "赵六" };
            //Mr m = new Mr(ss);
            //IEnumerator ie = m.GetEnumerator();
            //while (ie.MoveNext())
            //{
            //    Console.WriteLine(ie.Current.ToString());
            //}
            //Console.WriteLine("=====");
            #endregion
            #region 第二种方法：直接使用foreach来遍历
            //Mr mm = new Mr(ss);
            //foreach (var mk in mm)
            //{
            //    Console.WriteLine(mk);
            //}
            //Console.WriteLine("======");
            #endregion
            #region  另一种写法
            //Student s = new Student();
            //foreach (var t in s)
            //{
            //    Console.WriteLine(t);
            //}
            #endregion

            #region 数组
            //string[] strArry = new string[] { "A", "F", "G", "R" };
            ////string[] result = ArryAddItem(strArry, 4, "M");
            //string[] result = ArryDelItem(strArry, 2);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}
            #endregion


            //类的继承
            #region
            //Annimal a = new Annimal();
            //a.Creep();
            //Console.WriteLine(Annimal.ValueString);
            //Dog d = new Dog();
            //d.Creep();
            //d.Shout();

            //if (d is Annimal)
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是");
            //}
            #endregion

            #region 构造函数问题
            //Students ss = new Students("张山", "男", 20, "001");
            #endregion

            //抽象类和抽象方法
            #region
            //B b = new B();
            //Console.WriteLine(b.A2());
            //Console.WriteLine(b.C1());
            //C c = new C();
            //Console.WriteLine(c.C1());   
            #endregion

            //类和接口
            #region

            //Cow c = new Cow();
            //c.Time = 1.9;
            //c.Speed = 5.0;
            //double juli = c.Run();
            //Console.WriteLine("速度:{0} 时间:{1} 距离:{2}", c.Speed, c.Time, juli);
            #endregion

            //异常处理
            #region
            //Console.WriteLine(MyException(8));
            //Console.WriteLine(MyException(-8)); ////此处异常
            //Console.WriteLine(MyException(88)); ////此处异常
            #endregion

            //委托
            #region
            //MyDelehate hello;
            //hello = SayHello;
            //string s1 = hello("你好");
            //Console.WriteLine("SayHello 方法值是：{0}", s1);

            //hello += SayHi;
            //Console.WriteLine(hello("Hello"));

            //hello -= SayHi;
            //Console.WriteLine(hello("1"));
            #endregion

            //----------委托和事件--------
            #region 委托和事件
            //Heater heater = new Heater();
            //Alarm alarm = new Alarm();

            //heater.Boild += alarm.MakeAlert;    //注册方法
            //heater.Boild += (new Alarm()).MakeAlert;   //给匿名对象注册方法
            //heater.Boild += Displays.ShowMsg;       //注册静态方法

            //heater.BoildWater();   //烧水，会自动调用注册过对象的方法
            #endregion


            //*********序列化和反序列化(也叫格式化)*********
            //(1):序列化只序列化数据（比如：字段，属性），不序列化方法(方法不参与序列化)
            //(2):被序列化的类以及所有父类都必须是可序列化的
            //(3):被序列化的属性类型也必须是可序列化的
            //(4):给类中的字段设置为[NonSerializable]，表示该字段不参与序列化
            //二进制序列化注意点：被序列化的类必须标记为可序列化 [Serializable] 


            //1：Jason序列化是把文件变成string的过程
            //2：XML序列化，是把文件写成XML文件的过程
            //(将序列化写入流中，写入本地磁盘)
            #region
            //Human h = new Human("张三", "男", 23);
            //using (FileStream fs = new FileStream(@"G:\human.xml", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    XmlSerializer xml = new XmlSerializer(typeof(Human));
            //    xml.Serialize(fs, h);
            //}
            //Console.WriteLine("序列化OK");
            #endregion


            //3：二进制序列化
            //二进制序列化就是把文件变成byte[]字节数组的过程
            #region
            //Human hh = new Human("大伟", "男", 23);
            //BinaryFormatter bf = new BinaryFormatter(); //创建序列化器
            //using (FileStream fss = new FileStream(@"G:\hh.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    bf.Serialize(fss, hh);
            //}
            //Console.WriteLine("序列化OK");
            #endregion

            //二进制反序列化步骤
            #region
            //1：创建序列化器    
            //BinaryFormatter b = new BinaryFormatter();
            ////2:创建读取的文件流
            //object ob = null;
            //using (FileStream fsread = new FileStream(@"G:\hh.txt", FileMode.OpenOrCreate, FileAccess.Read))
            //{
            //    ob = b.Deserialize(fsread);
            //    Human hm = ob as Human;
            //    Console.WriteLine(hm.Name + "," + hm.Sex + "," + hm.Age);
            //}
            #endregion

            //序列化练习
            #region  数组序列化和反序列化
            //string p = @"G:\arrylist.txt";
            //1:序列化
            //ArrayList al = new ArrayList() { "hello", 2, 34, true, "你好" };

            //BinaryFormatter b = new BinaryFormatter();
            //using (FileStream f = new FileStream(p, FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    b.Serialize(f, al);
            //}
            //Console.WriteLine("序列化完毕OK");
            //Console.WriteLine("-----------");
            ////2:反序列化
            //BinaryFormatter by = new BinaryFormatter();
            //using (FileStream ff = new FileStream(p, FileMode.OpenOrCreate, FileAccess.Read))
            //{
            //    object o = by.Deserialize(ff);
            //    ArrayList a = o as ArrayList;

            //    foreach (var item in a)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion

            //序列化 
            #region 练习1--类型序列化
            //Human h = new Human("张三", "男", 19);   //根据human类创建一个对象

            //Console.WriteLine("开始序列化......");
            //BinaryFormatter bf = new BinaryFormatter();  //创建序列化qi
            //using (FileStream fs = new FileStream(@"G:\Persion.txt", FileMode.Create))
            //{
            //    bf.Serialize(fs, h);
            //}
            //Console.WriteLine("序列化OK,请查看对应的txt文件");
            ////反序列化
            //Console.WriteLine("开始反序列化......");
            //BinaryFormatter fbf = new BinaryFormatter();
            //using (FileStream r = new FileStream(@"G:\Persion.txt", FileMode.OpenOrCreate, FileAccess.Read))
            //{
            //    object obj = fbf.Deserialize(r);

            //    Human hm = obj as Human;   //将object类型转换成human类型
            //    Console.WriteLine(hm.Name + "\n" + hm.Sex + "\n" + hm.Age);
            //}
            //Console.WriteLine("反序列化OK");
            #endregion

            //序列化 
            #region 练习2--集合序列化
            //创建集合
            //ArrayList al = new ArrayList();
            //al.Add(false);
            //al.Add(10);
            //al.Add(3.14);
            //al.Add("Hello World!");
            //al.Add(new Human("保罗", "男", 23));
            ////序列化
            //BinaryFormatter bft = new BinaryFormatter();  //创建二进制序列化qi
            //using (FileStream fss = new FileStream(@"G:\ArryList.txt", FileMode.Create))
            //{
            //    bft.Serialize(fss, al);
            //}
            //Console.WriteLine("序列化OK" + "\r\n");
            ////反序列化
            //using (FileStream f = new FileStream(@"G:\ArryList.txt", FileMode.OpenOrCreate))
            //{
            //    object o = bft.Deserialize(f);   //反序列化得到object对象
            //    ArrayList all = o as ArrayList;   //将object类型对象转换成集合ArryList类型

            //    Console.WriteLine("反序列化结果如下:");
            //    for (int i = 0; i < all.Count; i++)
            //    {
            //        if (all[i] is Human)   //判断集合中的值是否有human类型
            //        {
            //            PropertyInfo[] info = all[i].GetType().GetProperties();  //获取human对象属性
            //            for (int j = 0; j < info.Length; j++)
            //            {
            //                Console.WriteLine(info[j].GetValue(all[i], null));  //根据属性获取值
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine(all[i]);    //其他不是human类型直接输出
            //        }
            //    }
            //}
            #endregion

            #region 文件编码--Encoding
            //Encoding code = Encoding.GetEncoding("gb2312");  //获取gb2312编码
            //Console.WriteLine(code.EncodingName);   //code.EncodingName获取编码的名称

            //EncodingInfo[] codes = Encoding.GetEncodings();  //获取编码数组
            //for (int y = 0; y < codes.Length; y++)
            //{
            //    string str = string.Format("{0}  {1}  {2}", codes[y].CodePage, codes[y].DisplayName, codes[y].Name);    //获取编码名称
            //    File.AppendAllText(@"G:\编码.txt", str + "\r\n");
            //}
            //Console.WriteLine("OK");
            #endregion

            #region 生成GUID码
            //string path = "D:\\guid.txt";
            //using (FileStream fs = File.Create(path))
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        string str = Guid.NewGuid().ToString("N");
            //        byte[] bt = Encoding.Default.GetBytes(str + "\r\n");
            //        fs.Write(bt, 0, bt.Length);
            //    }
            //}
            //Console.WriteLine("生成OK!!!");
            #endregion

            #region 类练习
            //MyIndex index = new MyIndex();
            //index.AddString("1");
            //index.AddString("2");
            //index.AddString("3");
            //index.AddString("4");
            //index.AddString("5");

            //int num = index.GetLength;
            //Console.WriteLine(num);

            //List<string> strs = index.GetL;
            //foreach (string s in strs)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion

            #region 类和构造函数使用
            //Students sts = new Students("张山", "男", 20, "001");
            #endregion

            #region 接口实现多态
            //IHunmanable IH = new America("Steven", "女", 30);//new Chinese("刘备", "男", 20);       
            //Human.Hun(IH);
            #endregion

            #region NewTon--Json序列化   （类序列化）
            //Human man = new Human("刘备", "男", 18);
            //string result = Newtonsoft.Json.JsonConvert.SerializeObject(man);
            //Console.WriteLine(result);

            //Human h1 = new Human("张山", "男", 23);
            //Human h2 = new Human("李四", "男", 20);
            //Human h3 = new Human("赵丽", "女", 19);

            //Human h4 = new Human("张山", "女", 26);
            //Human h5 = new Human("赵丽", "女", 17);
            //Human[] mans = new Human[] { h1, h2, h3 };
            //string Hresult = Newtonsoft.Json.JsonConvert.SerializeObject(mans);
            //Console.WriteLine(Hresult);

            //string StrResult = Newtonsoft.Json.JsonConvert.SerializeObject(mans, Formatting.Indented);
            //Console.WriteLine(StrResult);

            //Human[] hms1 = new Human[] { h1, h2, h3 };
            //Human[] hms2 = new Human[] { h4, h5 };

            //var temp = from a in hms1
            //           join b in hms2 on a.Name equals b.Name
            //           select new { Name = a.Name, Sex = b.Sex, Age = b.Age };
            //string HS = Newtonsoft.Json.JsonConvert.SerializeObject(temp);
            //Console.WriteLine(HS);
            #endregion

            #region 字符串操作附加
            //var strs1 = 100 + 1 + 2 + "3";
            //Console.WriteLine(strs1);


            //var strs2 = 1 + "2" + 3 + 100;
            //Console.WriteLine(strs2);

            //string str = "stusseyyuu";
            //int indexvalue = str.GetString("s", 2);

            //Console.WriteLine(indexvalue);

            //string result = str.RevseseString();
            //Console.WriteLine(result);

            //Dog d1 = new Dog();
            //d1.Kind = "001";
            //d1.Name = "二哈";
            //d1.Weight = 10;

            //Console.WriteLine(d1.ToString());
            #endregion

            #region 对象是否想等  GetHashCode()是object类型方法，子类也继承有该方法
            //Dog d1 = new Dog() { Kind = "001", Name = "jinmao", Weight = 20 };
            //Dog d2 = new Dog() { Kind = "001", Name = "jinmao", Weight = 20 };
            //Dog d3 = d2;
            //Console.WriteLine("d1={0}", d1.GetHashCode());
            //Console.WriteLine("d2={0}", d2.GetHashCode());

            //var result = d1.GetHashCode() == d2.GetHashCode() ? "相等" : "不等";   //不等
            //Console.WriteLine(result);
            //var result1 = d2.GetHashCode() == d3.GetHashCode() ? "相等" : "不等";  //相等
            //Console.WriteLine(result1);
            //var result2 = d1.GetHashCode() == d3.GetHashCode() ? "相等" : "不等";  //不等
            //Console.WriteLine(result2);
            #endregion

            //"=="和equal的区别
            #region 判断是否相等 "=="和equal()函数，string类型是个特例
            //string s1 = "123";
            //string s2 = "123";
            //Console.WriteLine(s1 == s2);  //true
            //Console.WriteLine(s1.Equals(s2));  //true

            //string s3 = s1;
            //Console.WriteLine(s1 == s3);  //true
            //Console.WriteLine(s1.Equals(s3));  //true

            //Annimal a = new Annimal();
            //Annimal aa = new Annimal();
            //Console.WriteLine(a == aa); //false
            //Console.WriteLine(a.Equals(aa));  //false

            //Annimal aaa = a;
            //Console.WriteLine(a == aaa); //true
            //Console.WriteLine(a.Equals(aaa));  //true
            #endregion

            #region 字符串练习补充
            ////字符串数组转换成字符串集合
            //string[] arr = { "你好", "圣诞节", "绥芬河" };
            //List<string> vs = new List<string>();
            //vs.AddRange(arr);
            //foreach (var str in vs)
            //    Console.WriteLine(str);

            ////字符串集合转换成字符串数组
            //List<string> strlist = new List<string>() { "is", "sfhi", "ahf" };
            //string[] vss = strlist.ToArray();
            //foreach (var str in vss)
            //    Console.WriteLine(str);


            ////将字符串转换成数组1
            //string s1 = "a,b,c,d,e,f,g";
            //string[] ss1 = s1.Split(',');
            //foreach (var str in ss1)
            //    Console.WriteLine(str);

            ////将字符串转换成int数组2
            //string s2 = "3,5,7,9,1,0";
            //int[] ss2 = Array.ConvertAll<string, int>(s2.Split(','), s => int.Parse(s));
            //foreach (var str in ss1)
            //    Console.WriteLine(str);

            ////将字符串转换成集合
            //string s3 = "a,b,c,d,e,f,g";
            //List<string> listr = new List<string>();
            //listr.AddRange(s3.Split(','));
            //foreach (var str in listr)
            //    Console.WriteLine(str);


            ////字符串练习其他
            //string rr = "369617";
            //bool isOk = rr.All<char>(cr => Convert.ToInt32(cr) >= 2);
            //bool a = rr.Any<char>();
            //IEnumerable<char> chrs = rr.AsEnumerable<char>();
            //foreach (char chr in chrs)
            //    Console.WriteLine(chr);
            //char crs = chrs.Max<char>();  //最大数

            //ParallelQuery<char> yu = rr.AsParallel<char>();
            //foreach (char chr in yu)
            //    Console.WriteLine(chr);

            //ParallelQuery<string> yuu = yu.Select<char, string>(chr => chr.ToString());
            //foreach (string chr in yuu)
            //    Console.WriteLine(chr);
            ////字符串的平均值
            //decimal avg = rr.Average<char>(s => decimal.Parse(s.ToString()));
            ////字符串去重
            //IEnumerable<char> dist = rr.Distinct<char>();

            ////字符串转换成键值对集合
            //int index = 0;
            //Dictionary<int, char> dire = rr.ToDictionary<char, int>(chr => index++);

            ////返回指定索引元素的位置
            //char c1 = rr.AsEnumerable<char>().ElementAt<char>(2);
            ////返回指定索引元素的位置，索引越界则返回默认值0
            //char c2 = rr.AsEnumerable<char>().ElementAtOrDefault(9);
            //char c22 = rr.ElementAt(5);  //由于字符串已经实现了IEnumerable接口，所以可以直接这样写

            ////从字符串中找到匹配的char
            //char big5 = rr.First<char>(s => s == '6');
            //Console.WriteLine(big5);

            ////字符串排序
            //IOrderedEnumerable<char> order1 = rr.AsEnumerable().OrderBy(c => c);
            //IOrderedEnumerable<char> order2 = rr.AsEnumerable().OrderByDescending(c => c);

            ////移除字符串中的一些数据
            ////rr.Remove(2, 4);
            ////其他字符串函数
            #endregion

            #region 数组练习补充
            //int[] srr = { 5, 7, 3, 0, 1 };
            //IEnumerable<int> nums1 = srr.DefaultIfEmpty();
            //IEnumerable<int> nums2 = srr.AsEnumerable();
            #endregion

            #region 邮箱正则表达式
            //string reg = @"^[a-zA-Z0-9]([a-z0-9]*[-_]?[a-z0-9]+)*@([a-z0-9]*[-_]?[a-z0-9]+)+[\.][a-z]{2,3}([\.][a-z]{2})?$";
            ////正则对象,指定不区分大小写
            //Regex regex = new Regex(reg, RegexOptions.IgnoreCase);
            //while (true)
            //{
            //    Console.WriteLine("请输入邮箱：");
            //    string email = Console.ReadLine();
            //    if (regex.IsMatch(email))
            //    {
            //        Console.WriteLine("邮箱正确，程序退出！");
            //        break;
            //    }
            //    else
            //        Console.WriteLine("输入错误！！");

            //}
            #endregion

            #region 使用扩展方法
            //string[] arry = new string[] { "qas", "er", "dgfs" };
            //bool b = arry.IsNullOrEmpty();

            //List<int> vs = new List<int> {
            //    2,8,1,5,8,7
            //};
            //bool c = vs.IsNullOrEmpty();

            //List<int> vss = new List<int>();
            //bool cc = vss.IsNullOrEmpty();

            //Dictionary<int, int> dir = new Dictionary<int, int>();
            //bool dd = dir.IsNullOrEmpty();
            #endregion




            //Console.ReadKey();

        }

        //----------------------泛型和委托方法-------------------
        /// <summary>
        /// 泛型委托
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lst"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        private static bool GetTs<T>(IEnumerable<T> lst, Action<IEnumerable<T>> action)
        {
            try
            {
                action(lst);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private static bool GetTs<T>(IEnumerable<T> lst, Func<IEnumerable<T>, bool> func)
        {
            try
            {
                return func(lst);
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 泛型和委托方法
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="t">泛型对象实例</param>
        /// <param name="func">委托方法</param>
        /// <returns></returns>
        public static bool Test<T>(T t, Func<T, bool> func)
        {
            bool isOk;
            try
            {
                isOk = func(t);
            }
            catch
            {
                isOk = false;
            }
            return isOk;
        }
        public static bool Test<T>(List<T> tarry, Action<T> action)
        {
            bool isOk;
            try
            {
                foreach (var t in tarry)
                {
                    action(t);
                }
                isOk = true;
            }
            catch
            {
                isOk = false;
            }
            return isOk;
        }

        //---------------------------方法----------------------
        /// <summary>
        /// 清空字符串空格
        /// </summary>
        /// <param name="Str"></param>
        /// <returns></returns>
        public static string ClearNull(string Str)
        {
            StringBuilder sb = new StringBuilder();
            if (Str.Trim() != "" && Str != string.Empty)
            {
                char[] c = Str.ToCharArray();
                foreach (char ch in c)
                {
                    if (ch == ' ')
                        sb.Append(string.Empty);
                    else
                        sb = sb.Append(ch.ToString());
                }
            }
            return sb.ToString();
        }
        /// <summary>
        /// 数据类型
        /// </summary>
        public static void DataRange()
        {
            Console.WriteLine("{0}的取值范围:{1}---{2}", "byte", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0}的取值范围:{1}---{2}", "sbyte", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("{0}的取值范围:{1}---{2}", "ushort", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("{0}的取值范围:{1}---{2}", "short", short.MinValue, short.MaxValue);
            Console.WriteLine("{0}的取值范围:{1}---{2}", "uint", uint.MinValue, uint.MaxValue);
            Console.WriteLine("{0}的取值范围:{1}---{2}", "int", int.MinValue, int.MaxValue);
            Console.WriteLine("{0}的取值范围:{1}---{2}", "ulong", ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("{0}的取值范围:{1}---{2}", "long", long.MinValue, long.MaxValue);
            Console.WriteLine("{0}的取值范围:{1}---{2}", "double", double.MinValue, double.MaxValue);
            Console.WriteLine("{0}的取值范围:{1}---{2}", "float", float.MinValue, float.MaxValue);
            Console.WriteLine("{0}的取值范围:{1}---{2}", "decimal", decimal.MinValue, decimal.MaxValue);
        }
        /// <summary>
        /// 值传递和引用传递（ref/out/params）
        /// </summary>
        public static void TranPara(int val, ref int refval)
        {
            val++;
            refval++;
            Console.WriteLine("val is {0},refval is {1}", val, refval);
        }
        public static void OutPara(int val, out int outval)
        {
            outval = 1;
            val += outval;
        }
        public static int Params(params int[] arr)
        {
            int sum = 0;
            if (arr.Length > 0)
            {
                foreach (int i in arr)
                {
                    sum += i;
                }
            }
            return sum;
        }

        /// <summary>
        /// 异常处理Exception(也可以使用Try....Catch处理)
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string MyException(int index)
        {
            int[] num = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            if (index > 9)
                throw new Exception("索引超出了范围！");
            if (index < 0)
                throw new Exception("索引不在范围之内！");
            return "存在该数据的索引";
        }

        /// <summary>
        /// 定义委托函数 SayHello和SayHi
        /// </summary>
        /// <param name="str1"></param>
        /// <returns></returns>
        public static string SayHello(string str1) => str1;
        public static string SayHi(string str2) => str2;


        //--------------file/Path/Directory类的使用--------------
        public static int num = 1;
        //遍历目录方法
        public static void ScareDir1(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            DirectoryInfo[] dr = di.GetDirectories();
            StringBuilder sb = new StringBuilder(path);
            foreach (DirectoryInfo d in dr)
            {
                if (d.GetDirectories().Length > 0)
                {
                    sb.Append("\\" + d);
                    ScareDir1(sb.ToString());
                }
                else
                    Console.WriteLine(sb.ToString() + "\\" + d);
            }

        }
        //创建目录
        #region
        public static void CreateDir(string path)
        {
            StringBuilder sb = new StringBuilder(path);
            while (num <= 3)
            {
                sb.Append("\\" + num);
                if (Directory.Exists(sb.ToString()))
                {
                    num++;
                    continue;
                }
                else
                    Directory.CreateDirectory(sb.ToString());
                num++;
            }
            Console.WriteLine("OK");
        }
        #endregion
        //删除目录和目录下的文件
        public static void DeleteDir(string dir)
        {
            if (Directory.Exists(dir)) //如果存在这个文件夹删除之 
            {
                foreach (string d in Directory.GetFileSystemEntries(dir))
                {
                    if (File.Exists(d))
                        File.Delete(d); //直接删除其中的文件 
                    else
                        DeleteDir(d); //递归删除子文件夹 
                }
                Directory.Delete(dir); //删除已空文件夹 
                Console.WriteLine(dir + " 文件夹删除成功");
            }
            else
            {
                Console.WriteLine(dir + " 该文件夹不存在"); //如果文件夹不存在则提示 
            }
        }


        //------------------------数组操作----------------------
        /// <summary>
        /// 数组添加元素到指定位置
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arry">数组</param>
        /// <param name="index">索引位置</param>
        /// <param name="item">添加元素</param>
        /// <returns>新数组</returns>
        public static T[] ArryAddItem<T>(T[] arry, int index, T item)
        {
            if (index <= 0)
                index = 0;
            if (index >= arry.Length)
                index = arry.Length;
            T[] newArry = new T[arry.Length + 1];
            for (int i = newArry.Length - 1; i > -1; i--)
            {
                if (i > index)
                    newArry[i] = arry[i - 1];
                else if (i == index)
                    newArry[i] = item;
                else
                    newArry[i] = arry[i];
            }
            return newArry;
        }
        /// <summary>
        /// 数组删除制定位置元素
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arry">数组</param>
        /// <param name="index">索引位置</param>
        /// <returns></returns>
        public static T[] ArryDelItem<T>(T[] arry, int index)
        {
            if (index <= 0)
                index = 0;
            if (index >= arry.Length)
                index = arry.Length - 1;
            T[] newArry = new T[arry.Length - 1];
            for (int i = arry.Length - 1; i > -1; i--)
            {
                if (i > index)
                    newArry[i - 1] = arry[i];
                else if (i < index)
                    newArry[i] = arry[i];
            }
            return newArry;
        }


    }

    //-----------------------类部分--------------------
    //枚举
    public enum Provinceandcity
    {
        北京 = 1,
        天津 = 2,
        河北 = 3,
        黑龙江 = 4
    }
    //结构
    public struct Home
    {
        //结构里面可以定义 =>  字段、属性、实例方法、静态方法
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void M1() { }
        public int M2() { return 1; }
        public static void M3() { }
        public static int M4() { return 1; }

        public Home(string name)     //结构中的构造函数只能给【字段】赋值，不能给属性赋值
        {
            this._name = name;    //结构的构造函数必须给所有的字段赋值，不能选择性赋值
        }

    }

    //第一种：实现类型可遍历,需要让该类实现IEnumerable的接口，目的是为了让当前类中添加GetEnumerator()方法
    #region
    public class Mr : IEnumerable
    {
        private string[] arr;
        public Mr(string[] ss)
        {
            this.arr = ss;
        }
        public int Count
        {
            get
            {
                return arr.Length;
            }
        }
        //一下两种方法，任选其一即可
        public IEnumerator GetEnumerator()    //接口的方法，返回值是一个枚举器
        {
            return new MrEnumerable(this.arr);      //返回值是MrEnumerable类型
        }
        //public IEnumerator GetEnumerator()      //接口的方法，返回值是一个枚举器
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        yield return arr[i];
        //    }
        //}
    }
    //如果希望一个类型可以被枚举，应该定义一个枚举器
    //定义一个枚举器类，实现IEnumerator接口（其实就是在一个类中定义枚举的方法）
    public class MrEnumerable : IEnumerator
    {
        private string[] _friends;
        public MrEnumerable(string[] fs)  //构造函数初始化数据
        {
            this._friends = fs;
        }

        //下标一般是第一个数据的前一个，也就是-1
        private int index = -1;      //索引位置在-1

        public object Current    //当前索引的位置
        {
            get
            {
                if (index >= 0 && index < this._friends.Length)
                    return this._friends[index];
                else
                    throw new Exception("索引超出范围");
            }
        }

        public bool MoveNext()   //索引移动到下一个
        {
            if (index < this._friends.Length - 1)
            {
                index++;
                return true;
            }
            return false;
        }

        public void Reset()   //重置索引
        {
            index = -1;
        }
    }
    #endregion

    //第二种：实现类型可遍历,也可以使用如下方法
    //(继承接口，实现GetEnumerator()方法，使用yield return返回值)
    #region
    public class Student : IEnumerable
    {
        //定义一个返回值是IEnumerable的方法，使用yield return 返回数据
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < this.friends.Length; i++)
            {
                yield return this.friends[i];
            }
        }

        private string[] friends = new string[] { "谢广坤", "刘能", "赵四" };
        public Student()
        { }
        public Student(string[] s)
        {
            this.friends = s;
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
    }
    #endregion

    /// <summary>
    /// MyIndex类
    /// </summary>
    public class MyIndex    //索引器（*重要）
    {
        private List<string> L = new List<string>();
        public void AddString(string str)
        {
            this.L.Add(str);
        }

        public List<string> GetL
        {
            get { return this.L; }
        }
        public int GetLength
        {
            get { return this.GetL.Count(); }
        }

        //读写索引器
        public string this[int nameindex]
        {
            //当值在索引范围内时，返回对应的索引值，否则“没有这个名称！”
            get
            {
                if (nameindex >= 0 && nameindex < this.L.Count)
                    return this.L[nameindex];
                else
                    return "没有这个名称！";
            }
            set
            {
                //当值在索引范围时，更新数据，否则，添加这个值到集合中
                if (nameindex >= 0 && nameindex < this.L.Count)
                    this.L[nameindex] = value;
                else
                    this.L.Add(value);
            }
        }
    }
    //泛型类实现算法重用---索引器（***非常重要***）
    public class MyIndexF<T>
    {
        private T _name;
        public T Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private List<T> _ml = new List<T>();  //声明泛型集合
        public T this[int index]   //针对集合创建索引器
        {
            get
            {
                if (index >= 0 && index < _ml.Count)
                    return this._ml[index];
                else
                    return (T)this._ml[index];
            }
            set
            {
                //索引超出时更新，没有超出则添加
                if (index >= 0 && index < _ml.Count)
                    this._ml[index] = value;
                else
                    this._ml.Add(value);
            }
        }

    }

    /// <summary>
    /// 父类与子类（继承）
    /// </summary>
    public class Annimal
    {
        public static string ValueString = "Annimal";

        private string _Kind;
        public string Kind
        {
            get { return _Kind; }
            set { _Kind = value; }
        }
        //定义虚方法
        public virtual void Creep()
        {
            Console.WriteLine("Annimal can Creep!!!");
        }
        /// <summary>
        ///重写基类object的ToString()方法
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
    public class Dog : Annimal
    {
        //子类字段和属性
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private double _Weight;
        public double Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }
        //子类方法
        public void Shout()
        {
            Console.WriteLine("Dog can Shouting!!!");
            base.Creep();  //通过base关键字调用父类的方法：显式的调用父类的方法实现
        }
        //重写父类的虚方法
        public override void Creep()
        {
            Console.WriteLine("Dog Can Creep!!!");
            base.Creep();  //通过base关键字调用父类的方法：显式的调用父类的方法实现
        }
    }
    /// <summary>
    /// 抽象类和抽象方法
    /// </summary>
    public abstract class A : C
    {
        public static string A1()  //非抽象方法（抽象类可以定义非抽象方法,静态方法，由抽象类直接调用）
        {
            return "A1";
        }
        public abstract string A2();  //抽象方法
        public string A3()      //非抽象方法（非静态方法，由子类实例化来调用）
        {
            return "A3";
        }
    }
    public class B : A
    {
        public override string A2()
        {
            return "A2";
        }
    }
    public class C
    {
        public string C1()
        {
            return "C1";
        }
    }
    public abstract class D : A
    {
        public abstract string D1();
        //抽象类可以定义非抽象方法(静态方法)
        public static string D2() => "D2";
        //抽象类可以定义非抽象方法(非静态方法，由子类实例化来调用)
        public string D3(string str) => str;
    }

    /// <summary>
    /// 类和接口
    /// </summary>
    public class Cow : IRunnable
    {
        private double _speed;
        private double _time;
        private double _distince = 0.00;
        //---实现接口的属性和方法---
        public double Speed
        {
            get
            {
                return this._speed;
            }
            set
            {
                this._speed = value;
            }
        }
        public double Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
            }
        }
        public double Distince
        {
            get
            {
                return this._distince;
            }
        }
        public double Run() => this._time * this._speed;
        public void Stop() => Console.WriteLine("Cow停止了奔跑！");
    }

    /// <summary>
    /// 定义接口IRunnable
    /// </summary>
    interface IRunnable
    {
        //Speed属性
        double Speed
        {
            get;
            set;
        }
        //Time属性
        double Time
        {
            get;
            set;
        }
        //Distince只读属性
        double Distince
        {
            get;
        }
        //接口方法
        double Run();
        void Stop();
    }

    /// <summary>
    /// 委托和事件
    /// </summary>
    //烧水类
    public class Heater
    {
        public delegate void BoildHeater(int temp); //定义一个委托
        public event BoildHeater Boild;  //定义一个事件

        private int _temperature;
        public int temperature
        {
            get { return _temperature; }
            set { _temperature = value; }
        }

        public void BoildWater()
        {
            for (int i = 0; i <= 100; i++)
            {
                temperature = i;
                if (temperature > 85)
                {
                    if (Boild != null)
                        Boild(temperature);
                }
            }
        }
    }

    // 警报器
    public class Alarm
    {
        public void MakeAlert(int param) => Console.WriteLine("Alarm：嘀嘀嘀，水已经 {0} 度了：", param);
    }

    // 显示器
    public class Displays
    {
        public static void ShowMsg(int param) => Console.WriteLine("Display：水快烧开了，当前温度：{0}度。", param);
    }

    /// <summary>
    /// 继承和构造函数问题 ---构造函数可以重载，但不能继承
    /// Base是子类构造函数调用父类的构造函数，this的一个用法是本类中构造函数调用
    /// </summary>
    public class Persons
    {
        //构造函数
        public Persons(string name, int age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
        //其他构造函数  ---this调用最全参数的构造函数
        public Persons(string name, string sex)
            : this(name, 0, sex)
        { }
        public Persons(string name, int age)
            : this(name, age, string.Empty)
        { }

        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public string Sex
        {
            get;
            set;
        }

        public static void A()
        { }

    }
    public class Teachers : Persons
    {
        //子类的所有构造函数都会调用父类的默认无参数构造函数，如果父类没有则
        //1:在父类Persons添加无参数构造函数
        //2:使用base关键字，告诉子类的构造函数去调用特定的父类构造函数
        public Teachers(string name, int age, string sex, string id)
            : base(name, age, sex)
        {
            this.Empid = id;
        }
        public string Empid
        {
            get;
            set;
        }
        //子类如果和父类如果有相同的方法，则会隐藏父类的方法，添加关键字NEW，可以解决重名问题
        //public static new void A()
        //{ }
    }
    public class Students : Persons
    {
        //子类的所有构造函数都会调用父类的默认无参数构造函数，如果父类没有则
        //1:在父类Persons添加无参数构造函数
        //2:使用base关键字，告诉子类的构造函数去调用特定的父类构造函数
        public Students(string name, string sex, int age, string id)
            : base(name, age, sex)
        {
            this.Sid = id;
        }
        public string Sid
        {
            get;
            set;
        }
    }

    //------------------------------静态类和实例类之间的继承关系-----------------
    //1:静态类不能有继承关系
    public static class jt1
    {
        public static string AA { get; set; }
        public static void A1()
        { }
    }
    public class fjt1
    {
        public static string BB { get; set; }
        public static void B1()
        { }
        public void B2()
        { }
    }
    public static class Jt2
    {
        public static string CC { get; set; }
        public static void C1()
        { }
    }
}