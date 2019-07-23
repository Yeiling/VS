using CSharp_BASE.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_BASE
{
    class Program
    {
        static void Main(string[] args)
        {
            //质数
            #region
            //int j, count = 0;
            //for (int i = 2; i <= 100; i++)
            //{
            //    for (j = 2; j < (int)(Math.Sqrt(i) + 1); j++)
            //    {
            //        if (i % j == 0)
            //            break;
            //    }
            //    if (j > (int)Math.Sqrt(i))
            //    {
            //        count++;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("共：" + count);
            #endregion

            //访问修饰符
            #region
            //private 只在当前类的内部可以访问
            //protected  在当前类和子类中可以访问
            //internal   在同一个程序集中可以访问
            //public 公开的，无访问限制
            #endregion

            //交换两个数字
            #region
            //int m = 10;
            //int n = 30;
            //方法1
            //n = m - n;  //n=-20 m=10
            //m = m - n;  //m=30,n=-20
            //n = m + n;
            //方法2
            //int temp = m;
            //m = n;
            //n = temp;
            //Console.WriteLine("m="+m+";"+"n="+n);
            #endregion

            //提示输入字符串，计算长度
            #region
            //Console.WriteLine("请输入一个字符串：");
            //string str = Console.ReadLine();
            //Console.WriteLine(str + "长度是：" + str.Length);
            #endregion

            //计算两个数的最大值
            #region
            //Console.WriteLine("请输入第一个值：");
            //int k = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个值：");
            //int h = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("maxnum=" + GetnumMax(k, h, 20, 99));

            //int[] a = { 2, 5, 0, 4 };
            //Console.WriteLine(GetnumMax(a));
            #endregion

            //判断一个数是否是质数
            #region
            //while (true)
            //{
            //    Console.WriteLine("请输入一个质数：");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    bool b = Iszhishu(num);
            //    if (b)
            //    {
            //        Console.WriteLine(num + "是质数！！！");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(num + "不是质数！！！");
            //    }
            //}
            #endregion

            //求数组的平均值，结果要四舍五入
            #region
            //int[] arr = { 3, 4, 9, 7 };
            //Console.WriteLine("平均数是：" + GetAvg(arr));
            #endregion

            //选择排序---每一次从剩下的数据中找到最大值，交换到对应位置
            #region 
            //int[] group = { 300, 500, 100, 900, 4000, 300, 800 };
            //int temp;
            //int pos = 0;
            //for (int i = 0; i < group.Length - 1; i++)
            //{
            //    pos = i;
            //    for (int j = i + 1; j < group.Length; j++)
            //    {
            //        if (group[j] < group[pos])
            //            pos = j;
            //    }//第i个数与最小的数group[pos]交换
            //    temp = group[i];
            //    group[i] = group[pos];
            //    group[pos] = temp;
            //}

            //foreach (var v in group)
            //    Console.WriteLine(v);
            #endregion

            //冒泡排序
            #region
            //int[] arr = { 2, 0, 87, 30, 29, 3, 1 };
            //arr = MPPX(arr);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //double[] dd = { 2.9, 0.9, 8.7, 30.0, 2.9, 3, 10.87 };
            //dd = MPPX(dd);
            //for (int i = 0; i < dd.Length; i++)
            //    Console.WriteLine(dd[i]);

            //int[] arrs = { 2, 0, 87, 30, 29, 3, 1 };
            //int max = 0;
            //for (int i = 0; i < arrs.Length - 1; i++)
            //{
            //    for (int j = 0; j < arrs.Length - 1 - i; j++)
            //    {
            //        if (arrs[j] > arrs[j + 1])
            //        {
            //            max = arrs[j];
            //            arrs[j] = arrs[j + 1];
            //            arrs[j + 1] = max;
            //        }
            //    }
            //}
            //foreach (int num in arrs)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            //例如：1-100里随机不重复的数排序----散列排序或者哈希排序
            #region
            //int[] data = { 60, 2, 5, 89, 21, 75, 10, 4, 19, 0, 55, 100, 7, 61, 38, 84, 30, 50, 17, 9 };
            //int[] temp = GetLXSort(data, 1);
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    if (temp[i] == 1)
            //        Console.WriteLine(i);
            //}
            #endregion

            //求数组最大值
            #region
            //int[] data = { 60, 2, 5, 89, 21, 75, 10, 4, 19, 0, 55, 100, 7, 61, 38, 84, 30, 50, 17, 9 };
            //int max = data[0];
            //for (int i = 0; i < data.Length; i++)
            //    max = (data[i] > max) ? data[i] : max;
            //Console.WriteLine(max);
            #endregion

            //字符串的练习(请算出字符串中“歌”字出现的次数)
            //如果判断字符串里有且仅有一个“歌”字符串，则可以判定indexof()=lastindexof()
            #region 第一种写法
            //string str = "唱歌就唱好歌，歌不好，还唱什么歌?";
            //int index = 0, count = 0;
            //while ((index = str.IndexOf("歌", index)) != -1)
            //{
            //    count++;
            //    Console.WriteLine("第{0}次出现的索引是{1}", count, index);
            //    index = index + "歌".Length;
            //}
            //Console.WriteLine("总共出现{0}次", count);
            #endregion

            #region 另一种写法
            //string str = "唱歌就唱好歌，歌不好，还唱什么歌";
            //计算“歌”字出现的索引和次数
            //char[] chr = str.ToCharArray();
            //int index = 0;
            //for (int i = 0; i < chr.Length; i++)
            //{
            //    if (chr[i].ToString() == "歌")
            //    {
            //        index++;
            //        Console.WriteLine(i + "次出现了");
            //    }
            //}
            //Console.WriteLine("出现" + index + "次");

            //计算每一个字符出现的次数
            //string str = "唱歌就唱好歌，歌不好，还唱什么歌";
            //Dictionary<char, int> dir = new Dictionary<char, int>();
            //for (int k = 0; k < str.Length; k++)
            //{
            //    if (dir.ContainsKey(str[k]))
            //        dir[str[k]]++;  //如果有key,则key对应的value加1
            //    else
            //        dir.Add(str[k], 1);  //如果没有key值，则加进去一个
            //}
            //foreach (char c in dir.Keys)
            //    Console.WriteLine(c + ":" + dir[c]);
            #endregion

            #region 计算每一个字符出现的次数
            //string st = "唱歌就唱好歌，歌不好，还唱什么歌";
            //Dictionary<char, int> d = new Dictionary<char, int>();
            //for (int k = 0; k < st.Length; k++)
            //{
            //    if (d.ContainsKey(st[k]))
            //        d[st[k]]++;  //如果存在键，就将该键对应的值加一
            //    else
            //        d.Add(st[k], 1);
            //}
            ////遍历键值对
            //foreach (char key in d.Keys)
            //    Console.WriteLine("\'" + key + "\'" + " 出现了 " + d[key] + "次");
            #endregion

            //替换字符串的空格
            #region
            //string s = " hello world，  你好 世界  ";
            //s = s.Trim();  //去除两边空格
            //Console.WriteLine("==" + s + "==");
            ////去除所有空格
            //string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //s = string.Join("", words);
            //Console.WriteLine("==" + s + "==");

            //string ss = "  u 8 9 uh  hiu  hd ";
            //ss = QCKG(ss);
            //Console.WriteLine(ss);
            #endregion

            //将阿拉伯数字转换成
            //string sz = "2016年是1个不寻常的年度";
            //sz = ConvertToUpper(sz);
            //Console.WriteLine(sz);

            //字符串的的特性：不可变性(字符串一旦创建，则在堆中的值就不可以更改)
            //string str = "hello word";
            //string s = "你好，世界";
            //str = str + s;    //此处表示重新在堆中开辟空间，存放str+s的值，并指向了str，而之前str创建的值没有改变
            //Console.WriteLine(str);

            //字符串池:依赖于字符串的不可变性，如下示例，会将变量放到字符串池中，便于程序随时存取
            //由于池只有在程序退出才释放，所以避免定义一个很长的字符串
            //string ss = "a";
            //string bb = "b";
            //string wz = "一个十万字的论文";  //不合适

            //字符串的格式化
            #region
            //Console.WriteLine("我是{0}，今年{1},现在时间是{2}", "德文", 23, DateTime.Now.ToLongDateString());
            //Console.WriteLine(string.Format("{0:yyyyMMddHHmmss}", DateTime.Now));
            //Console.WriteLine(string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now));
            //Console.WriteLine(string.Format("{0:C2}", 8000));  //货币格式

            //string方法
            //string msg = "123--56-27----90-9";   //编程"123-56-27-90-9"
            //string[] strarr = msg.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            //string newmsg = string.Join("-", strarr);
            //Console.WriteLine(newmsg);
            #endregion

            //字符串连接（运算）
            #region
            //var strs1 = 100 + 1 + 2 + "3";
            //Console.WriteLine(strs1);     //1033
            //var strs2 = 1 + "2" + 3 + 100;
            //Console.WriteLine(strs2);     //123100
            #endregion

            //字符串拼接问题
            #region
            //var strs1 = 1 + 2 + "3";
            //Console.WriteLine(strs1);

            //var strs2 = 1 + "2" + 3;
            //Console.WriteLine(strs2);
            #endregion

            //索引器的使用
            #region
            //ItcastClass ic = new ItcastClass();
            //for (int i = 0; i < ic._count; i++)
            //    Console.WriteLine(ic[i]);

            //ItcastClass itc = new ItcastClass();
            //int num = itc._count;
            //Console.WriteLine("共有{0}个人", num);
            //Console.WriteLine("分别是:");
            //for (int j = 0; j < itc._count; j++)
            //    Console.WriteLine(itc[j].ToString());

            //InternalIndex it = new InternalIndex();
            //it.id = 123;
            //it.name = "张三";
            //List<InternalIndex> l = it.addList(it);
            //Console.WriteLine(l[0].id + l[0].name);
            #endregion

            //数组的翻转，(重载方法)
            #region
            //int[] numarr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //numarr = ReverseArr(numarr);
            //for (int i = 0; i < numarr.Length; i++)
            //    Console.WriteLine(numarr[i]);

            //string[] strarr = { "反对", "那我", "王力宏", "方法", "不必", "好" };
            //strarr = ReverseArr(strarr);
            //for (int i = 0; i < strarr.Length; i++)
            //    Console.WriteLine(strarr[i]);
            #endregion

            //类的继承和构造函数初始化
            //chongzai c = new chongzai("张三");
            //Console.WriteLine(c.Name);

            //Test1 t = new Test1("李四", "男");
            //Console.WriteLine(t.Name + ",,,," + t.Tsex);

            //提示用户输入用户名，然后再提示输入密码，如果用户名是“admin”并且密码是“888888”，则提示正确，
            //否则提示错误，如果用户名不是admin还提示用户用户名不存在。
            #region
            //Console.WriteLine("请输入用户名：");
            //while (true)
            //{
            //    string name = Console.ReadLine();
            //    if (name != "admin")
            //        Console.WriteLine("用户名错误！请重新输入");
            //    else
            //    {
            //        Console.WriteLine("请输入密码：");
            //        while (true)
            //        {
            //            string pwd = Console.ReadLine();
            //            if (pwd != "8888")
            //                Console.WriteLine("密码错误，请重新输入");
            //            else
            //                Console.WriteLine("恭喜你，用户名和密码都对了！！！");
            //        }
            //    }
            //}
            #endregion

            //提示用户输入年龄，如果大于等于18，则告知用户可以查看，
            //如果小于10岁，则告知不允许查看，如果大于等于10岁，则提示用户是否继续查看（yes、no），如果输入的是yes则提示用户可以查看，否则提示不可以查看。（给出测试用例。）
            #region
            //while (true)
            //{
            //    Console.WriteLine("请输入你的年龄：");
            //    string age = Console.ReadLine();
            //    try
            //    {
            //        int iage = Convert.ToInt32(age);
            //        if (iage >= 18)
            //        {
            //            Console.WriteLine("你的年龄是{0},可以查看了", iage);
            //            break;
            //        }
            //        else
            //        {
            //            if (iage < 10)
            //                Console.WriteLine("你的年龄是{0},不允许查看！", iage);
            //            else
            //            {
            //                Console.WriteLine("你的年龄是{0},可以查看！", iage);
            //                Console.WriteLine("是否继续查看？  Yes/NO");
            //                while (true)
            //                {
            //                    string daan = Console.ReadLine();
            //                    if (daan.ToLower() == "yes")
            //                        Console.WriteLine("尽情的看吧！");
            //                    else if (daan.ToLower() == "no")
            //                        Console.WriteLine("好吧，很遗憾，你选择了推出！");
            //                    else
            //                        Console.WriteLine("你输入的是什么鬼东西？ 是否继续查看？  Yes/NO");
            //                }
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("异常信息：{0}", ex.Message.ToString());
            //        continue;
            //    }

            //}
            #endregion

            //将一个字符串数组输出为|分割的形式，比如{“浮云”,”神马”,”穿梭”}数组输出为“浮云|神马|穿梭”。
            //不要使用String.Join等.Net内置方法。
            #region  方法1：
            //string[] str = { "神马", "都是", "浮云" };
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (i < str.Length - 1)
            //    {
            //        sb.Append(str[i]);
            //        sb.Append("|");
            //    }
            //    else
            //        sb.Append(str[i]);
            //}
            //Console.WriteLine("获得字符串是:{0}", sb.ToString());
            #endregion

            #region 方法2
            //string[] strr = { "神马", "都是", "浮云" };
            //string s = null;
            //for (int i = 0; i < strr.Length; i++)
            //    s = string.Join("|", strr);
            //Console.WriteLine("获得字符串是:{0}", s);
            #endregion

            //有一个整数数组，请声明一个字符串数组，将整数数组中的每一个元素的值转换为字符串保存到字符串数组中。
            #region
            //int[] arry = { 10, 9, 81, 49, 31, 77, 1, 63 };
            //string[] strarry = new string[arry.Length];
            //for (int k = 0; k < arry.Length; k++)
            //    strarry[k] = arry[k].ToString();
            //for (int h = 0; h < strarry.Length; h++)
            //    Console.WriteLine("第{0}个字符是{1}", h, strarry[h]);
            #endregion

            //将一个字符串数组的元素的顺序进行反转。{"3","a","8","haha"} 转换为{"haha","8","a","3"}。
            //提示：第i个和第length-i-1个进行交换。
            #region
            //string[] sss = { "3", "a", "8", "haha" };
            //int arer = sss.Length / 2;
            //for (int j = 0; j < arer; j++)
            //{
            //    string temp = sss[j];
            //    sss[j] = sss[sss.Length - j - 1];
            //    sss[sss.Length - j - 1] = temp;
            //}
            //for (int jj = 0; jj < sss.Length; jj++)
            //    Console.WriteLine("第{0}个字符是{1}", jj, sss[jj]);
            #endregion

            //求整数数组中的最大值
            #region
            //int[] num = { 10, 2, 53, 45, 39, 20, 99, 30 };
            //int max = num[0];
            //foreach (int arr in num)
            //{
            //    if (max < arr)
            //        max = arr;
            //}
            //Console.WriteLine("最大值是{0}", max);
            #endregion

            //多态练习
            #region
            //Person p = new Person();
            //p.Name = "张三";
            //p.Sex = "男";
            //p.Age = 18;
            //Console.WriteLine(p.ToString());  //由于重写了tostring()方法，此处调用重写后的方法
            #endregion

            //里氏转换
            #region
            //Man m = new Man();
            ////if (m is Person)
            ////    Person p = (Person)m;  //第一种转换方式
            //Person p = m as Person;  //第二种转换方式,效率高，as 转换，如果失败，返回null
            //p.Name = "大卫";
            //p.Sex = "男";
            //p.Age = 23;
            //Console.WriteLine(p);
            #endregion

            //抽象类（标准写法：将创建的子类赋给父类对象）
            #region
            //AbstractPerentClass p = new AbstractChildClass();
            //Console.WriteLine(p.SayHi());
            //p.SayHello();

            //string stry = Hello(p);
            //Console.WriteLine(stry);

            //AbstractPerentClass apc = Hi(p);
            //Console.WriteLine(apc.ToString());

            //AbstractChildClass acc = apc as AbstractChildClass;
            //Console.WriteLine(acc.ToString());
            #endregion

            //抽象类练习----计算器 
            #region
            //Console.WriteLine("请输入计算法则：");
            //string fz = Console.ReadLine();

            //Cal c = null;
            //switch (fz)
            //{
            //    case "+":
            //        c = new JiaFa();
            //        break;
            //    case "-":
            //        c = new JianFa();
            //        break;
            //}
            //try
            //{
            //    Console.WriteLine("几个数参与运算?");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    double[] arr = new double[num];
            //    for (int i = 0; i < num; i++)
            //    {
            //        Console.WriteLine("请输入第" + (i + 1) + "个数");
            //        arr[i] = Convert.ToDouble(Console.ReadLine());
            //    }
            //    c.dbarr = arr;
            //    Console.WriteLine(c.Jisuan());
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //}
            #endregion

            //值传递和引用传递
            //通常都是值传递，ref传递称作引用传递
            //值传递相当于在栈中拷贝一个副本或者引用地址，引用传递相当于两个值都指向同一个栈的地址
            //ref、out、params
            #region
            //string msg = Params_test("大卫", "男", 23, new int[] { 99, 87, 49, 90 });
            //Console.WriteLine(msg);

            //msg = Params_test("德文", "男", 25, 99, 69, 89, 90);
            //Console.WriteLine(msg);

            //msg = Params_test("灰", "男", 26, null);  //可变参数可以不赋值，也可以赋值为“null”
            //Console.WriteLine(msg);

            //out
            //int a;
            //int r = out_test(out a);  //out参数不需要赋值
            //Console.WriteLine(r);

            //int b = 1;
            //int t = ref_test(ref b);
            //Console.WriteLine(t);
            #endregion

            //比较两个对象是否为同一个对象:
            //当需要比较两个对象是否为同一个对象时，使用：object.ReferenceEquals(object ob1,object ob2)
            #region
            //string s1 = "123";
            //string s2 = "123";
            //bool b = s1.Equals(s2);  //使用“==”和equals方法不能有效判断
            //Console.WriteLine(b);

            //bool b1 = (s1 == s2) ? true : false;
            //Console.WriteLine(b1);

            //bool b2 = object.ReferenceEquals(s1, s2);
            //Console.WriteLine(b2);
            #endregion

            //StringBuilder更高效的字符串操作(常用来凭借字符串)
            #region
            //string str = File.ReadAllText(@"D:\WinPing.txt", Encoding.Default);
            //Console.WriteLine(str);
            #endregion

            //垃圾回收
            //值变量使用完就回收，回收机制只回收引用类型的数据，也就是堆中的内存资源（具体什么是否回收由系统决定）
            #region
            //Person p = new Person("李四", "男", 23);
            //Person p1 = p;
            //p = null;      //程序执行到这一步时， p对象没有释放，因为p1正在引用p

            //p1 = null;    //到此p对象是可以回收了，但什么是否回收由系统决定
            #endregion
            //手动调用垃圾回收,一般不需要手动调用回收（如果过多的手动释放资源，反而会降低程序执行效率）
            //GC.Collect();

            //析构函数:（函数前加"~"符号）

            //弱引用（类似于分手后保留QQ号）
            #region
            //Person pp = new Person("pp", "女", 20);
            //Console.WriteLine("====pp正在使用=====");
            //Console.WriteLine("====pp正在使用=====");
            //Console.WriteLine("====pp正在使用=====");

            //WeakReference wr = new WeakReference(pp);  //将对象pp弱引用

            //pp = null;

            //if (wr.IsAlive)                             //重新使用，先判断是否活着（是否被垃圾回收机制回收）
            //{
            //    object o = wr.Target;
            //    if (o != null)
            //    {
            //        pp = o as Person;
            //        //就可以使用pp了
            //        Console.WriteLine("====pp活了====");
            //    }
            //}
            #endregion

            //类型转换
            #region
            //int m = 10;
            //double d = m;   //隐式类型转换

            //string s = "120";
            //int n = Convert.ToInt32(s);  //显示类型转换

            //double num;
            //bool b = double.TryParse(s, out num);
            //Console.WriteLine(b + "   " + num);

            //int f = int.Parse(s);
            //Console.WriteLine("f:" + f);

            //// is 和 as的用法
            #endregion

            //异常try...catch...finally (可以有多个catch段，finally可有可无，try必须有)
            #region
            //Console.WriteLine("请输入一个数字：");
            //try
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());  //输入“abc”
            //    if (num > 1000)
            //        throw new Exception("数字超出了规定的值！！！"); //自定义异常
            //    else if (num < -1000)
            //        throw new Exception("数字小于规定的值！！！");  //自定义异常
            //    else
            //        Console.WriteLine(num);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    //throw;   //这种写法只能写在catch块中，用于将异常继续向上抛出
            //}
            //finally
            //{
            //    Console.WriteLine("-----------------------");
            //}
            #endregion

            //接口，接口的实现不需要override关键字
            //实现接口，必要实现接口内的所有成员，抽象类除外（抽象类可以将接口中的成员定义为抽象的，有子类来实现）,访问修饰符是 public
            //当多个接口中存在方法名重名的时候，才用到“显示实现接口”,显示实现接口的访问修饰符是 private,防止通过类来调用

            //集合（非泛型集合和泛型集合）
            //ArrayList,Hashtable,List<T>,Dictionary<K,V>
            //栈集合：先进后出   队集合：先进先出

            //ArrayList
            #region
            //ArrayList al = new ArrayList();
            //al.Add("hello");
            //al.Add(33);
            //al.Add(true);
            //al.Add(3.14);
            //al.Add('男');

            //al.AddRange(new int[] { 1, 3, 5, 7, 8, 10, 12 });  //添加任意的数组或者集合

            //al.Insert(3, "霓虹");     //在指定的索引处插入值
            //al.RemoveAt(4);          //删除集合中指定索引的值

            //Console.WriteLine("集合的容量是{0}", al.Capacity);
            //Console.WriteLine("集合实际数量是{0}", al.Count);
            ////al.Sort();   //升序排序
            ////al.Reverse();  //翻转集合
            //for (int i = 0; i < al.Count; i++)
            //    Console.WriteLine(al[i]);
            ////删除集合元素
            ////al.Clear();
            #endregion

            //练习---将a集合中的元素提升添加到all集合中(不允许重复)
            #region
            //ArrayList all = new ArrayList() { "a", "b", "c", "d", "e" };
            //ArrayList a = new ArrayList() { "a", "e", "g", "t", "y" };
            //for (int i = 0; i < a.Count; i++)
            //{
            //    if (!all.Contains(a[i]))
            //        all.Add(a[i]);
            //}
            //for (int k = 0; k < all.Count; k++)
            //    Console.WriteLine(all[k]);
            #endregion

            //练习--随机产生1-100之间的10个整数，必须是偶数，添加到集合中，不允许有重复
            #region
            //ArrayList num = new ArrayList();
            //int index = 0;
            //while (true)
            //{
            //    Random r = new Random();
            //    int rnum = r.Next(1, 101);
            //    if (rnum % 2 == 0)
            //    {
            //        if (!num.Contains(rnum))
            //        {
            //            num.Add(rnum);
            //            index++;
            //        }
            //    }
            //    else
            //        continue;

            //    if (index >= 10)
            //        break;
            //}

            //for (int i = 0; i < num.Count; i++)
            //    Console.WriteLine("第{0}个数是{1}", i, num[i]);
            #endregion

            //小写转换大写----阿拉伯小写转大写
            #region
            //Dictionary<char, string> d = new Dictionary<char, string>();
            //d.Add('0', "零");
            //d.Add('1', "壹");
            //d.Add('2', "贰");
            //d.Add('3', "叁");
            //d.Add('4', "肆");
            //d.Add('5', "伍");
            //d.Add('6', "陆");
            //d.Add('7', "柒");
            //d.Add('8', "捌");
            //d.Add('9', "玖");

            //string str = "1234567890";
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < str.Length; i++)
            //{
            //    char index = str[i];
            //    sb.Append(d[index]);
            //}
            //Console.WriteLine(sb.ToString());
            #endregion

            //比较两个字符串的大小---小插曲
            #region
            //string s = "abc";
            //string ss = "ABC";
            //int eql = ss.CompareTo(s);
            //Console.WriteLine(eql);  //1

            //int r = string.Compare(ss, s);
            //Console.WriteLine(r);   //1
            #endregion

            //递归
            //方法在自己内部调用自己，递归应当有必要的停止条件
            #region
            //int num = 5;
            //int dgsum = DG(num);
            //Console.WriteLine(dgsum);
            #endregion

            //var
            //var和声明一个变量是一样的 如：var m=100; int m=100;这两个赋值是一样的
            //在C#中，var依然是强类型，而JS中的var是弱类型，完全不一样
            //在C#中，var声明必须赋初值，否则会报错，而且var不能是方法返回值和参数，只能作局部变量使用


            //装箱和拆箱（尽量使用泛型集合，避免重复的装箱和拆箱，造成性能损耗）
            //值类型：int,double,float,long,char,byte
            //引用类型：object，string,数组，类，接口，委托
            //值类型转换成引用类型是装箱，引用类型转换成值类型是拆箱

            //注：装箱的时候用什么类型，拆箱的时候也用什么类型来接收
            #region
            //int num = 100;
            //object o = num;  //发生了一次装箱
            //int n = (int)o;  //发生了一次拆箱

            //string rt = num + "123" + n;   //此处发生了两次装箱


            //int m = 100;
            //Console.WriteLine(m);  //此处没有发生装箱
            //string s = Convert.ToString(m);  //没有装箱
            //double t = 3.14;
            //string ss = Convert.ToString(t); //没有装箱
            //int k = Convert.ToInt32(s);      //没有拆箱
            //Console.WriteLine("{0},{1},{2}", m, t, k);   //此处发生三次装箱
            #endregion

            //键值对集合
            #region
            //Dictionary<char, int> dt = new Dictionary<char, int>();
            //dt.Add('零', 0);
            //dt.Add('一', 1);
            //dt.Add('二', 2);
            //dt.Add('三', 3);
            //dt.Add('四', 4);
            //dt.Add('五', 5);
            //dt.Add('六', 6);
            //dt.Add('七', 7);
            //dt.Add('八', 8);
            //dt.Add('九', 9);

            //string sys = "今天是二零一七年十月一日，再过四十九天是二零一七年十一月二十九日";
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < sys.Length; i++)
            //{
            //    if (sys[i] == '十')    //处理“十”的问题
            //    {
            //        if (!dt.ContainsKey(sys[i - 1]) && !dt.ContainsKey(sys[i + 1]))
            //            sb.Append("10");  //十
            //        else if (!dt.ContainsKey(sys[i - 1]) && dt.ContainsKey(sys[i + 1]))
            //            sb.Append("1");  //十七
            //        else if (dt.ContainsKey(sys[i - 1]) && !dt.ContainsKey(sys[i + 1]))
            //            sb.Append("0"); //二十
            //        else if (dt.ContainsKey(sys[i - 1]) && dt.ContainsKey(sys[i + 1]))
            //            sb.Append(""); //例如二十九
            //    }
            //    else if (dt.ContainsKey(sys[i]))   //十以外的其他数字
            //        sb.Append(dt[sys[i]]);
            //    else               //其他非数字的字
            //        sb.Append(sys[i]);
            //}

            //Console.WriteLine(sb.ToString());
            #endregion

            //自定义泛型类
            //非泛型类也可以创建泛型方法

            //泛型接口与普通类
            #region
            //MyType<string> my = new MyType<string>();
            //my.SayHi("你好,世界");
            //my.Sayhello<string>("Hello World");

            //YouType<float, int, double> you = new YouType<float, int, double>();
            //you.SayHi(3.776f, 23, 3.14);
            #endregion

            ////泛型接口与泛型类
            #region
            //jiekouF<string, double> jikouf = new jiekouF<string, double>();
            //string str = jikouf.Say("你好，世界");
            //Console.WriteLine(str);
            //jikouf.Show("hello world ", 3.14);
            #endregion

            //单例模式---类
            #region
            //Simple s1 = Simple.sim;
            //Simple s2 = Simple.sim;

            //Console.WriteLine(s1 == s2 ? "==是同一个" : "不是同一个");
            //Console.WriteLine(s1.Equals(s2) ? "equal是同一个" : "不是同一个");
            #endregion

            //扩展方法和委托使用案例
            #region
            //List<string> strs = new List<string>() { "1990", "2010", "1978", "2014", "1999", "1989" };
            ////var tems = strs.Where(s => s.Contains("1"));
            //var temp = strs.Where((string s) => s.Contains("0"));
            //foreach (var v in temp)
            //    Console.WriteLine(v);

            //判断集合中的所有元素都满足某一个条件
            //bool b = strs.All(s => s.Contains("0"));
            //Console.WriteLine(b);

            ////string类型数据转换函数获取平均值
            //decimal dc = strs.Average(s => Convert.ToDecimal(s));
            //Console.WriteLine(dc);

            //数组的使用
            //int[] nums = new int[] { 3, 7, 1, 0, 5, 2, 6 };
            //IEnumerable<int> mynums = nums.Where(i => i > 5);
            //foreach (var v in mynums)
            //    Console.WriteLine(v);

            ////数组平均值
            //Console.WriteLine("平均值是：" + nums.Average());

            ////数组排序
            //IOrderedEnumerable<int> numarr = nums.OrderBy(i => i);
            //foreach (var v in numarr)
            //    Console.WriteLine(v);
            #endregion

            //-------------Stream流，输入和输出流-----------
            //1:FileStraem文件流  
            #region  将字符串写到文件中
            //string str = @"1.两种异步文件上传方式的比较2.jquery.validate校验表单3.微软提供的校验插件4.后台使用ModelState校验5.使用partial类为EF中的实体属性添加特性标签";
            //byte[] bts = Encoding.Default.GetBytes(str);
            //using (FileStream fs = new FileStream(@"G:\temp.txt", FileMode.Create, FileAccess.Write))
            //{
            //    fs.Write(bts, 0, bts.Length);
            //}
            #endregion
            var result = GetSum(100);


            A a = new A();
            a.Test();
            a.Test1();

            A aa = new A1();
            aa.Test();
            aa.Test1();

            A aaa = new A2();
            aaa.Test();
            aaa.Test1();

            Console.ReadKey();
        }

        //-----------------方法-------------------

        /// <summary>
        /// 求和算法   1-2+3-4+5-6+7
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int GetSum(int num)
        {
            int result = 0;
            #region 算法1
            //for (int i = 1; i <= num; i++)
            //{
            //    if (i % 2 == 0)
            //        result -= i;
            //    else
            //        result += i;
            //}
            #endregion
            #region 算法2
            if (num % 2 == 0)
                result = (num / 2) * -1;
            else
                result = ((num / 2) * -1) + num;
            #endregion
            return result;
        }

        //递归求一个数的阶乘
        /// <summary>
        /// 递归操作练习
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int DG(int num)
        {
            if (num == 0 || num == 1)
                return 1;
            return num * DG(num - 1);
        }

        /// <summary>
        /// out:out参数必须在方法内部给参数变量赋值,out参数在方法执行完毕前必须赋值‘’带出去‘’
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int Out_test(out int num)
        {
            num = 100;
            num++;
            return num;
        }
        static int ref_test(ref int num)
        {
            num++;
            return num;
        }
        //params:可变参数可以传递参数，也可以不传递参数；可变参数作为参数，只能放在最后面；也可以直接传递一个数组进来
        static string Params_test(string name, string sex, int age, params int[] score)
        {
            StringBuilder sb = new StringBuilder();
            if (score != null)
            {
                for (int i = 0; i < score.Length; i++)
                    sb.Append(score[i] + ",");
            }
            return name + sex + age + sb.ToString();
        }

        /// <summary>
        /// 写一个方法，参数是抽象类或者返回值是抽象类（这样就可以把子类当作参数或者返回值了，更灵活）
        /// </summary>
        /// <param name="apc"></param>
        /// <returns></returns>
        static string Hello(AbstractPerentClass apc) => apc.SayHi();
        static AbstractPerentClass Hi(AbstractPerentClass apc) => apc;

        /// <summary>
        /// 数组的翻转
        /// </summary>
        /// <param name="arrint"></param>
        /// <returns></returns>
        static int[] ReverseArr(int[] arrint)
        {
            int cishu = arrint.Length / 2;
            if (cishu > 0)
            {
                for (int i = 0; i < cishu; i++)
                {
                    int temp = arrint[arrint.Length - i - 1];
                    arrint[arrint.Length - i - 1] = arrint[i];
                    arrint[i] = temp;
                }
            }
            return arrint;
        }
        /// <summary>
        /// 数组的翻转
        /// </summary>
        /// <param name="arrstring"></param>
        /// <returns></returns>
        static string[] ReverseArr(string[] arrstring)
        {
            int cishu = arrstring.Length / 2;
            if (cishu > 0)
            {
                for (int i = 0; i < cishu; i++)
                {
                    string temp = arrstring[arrstring.Length - i - 1];
                    arrstring[arrstring.Length - i - 1] = arrstring[i];
                    arrstring[i] = temp;
                }
            }
            return arrstring;
        }

        /// <summary>
        /// 阿拉伯数字转换成大写
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static string ConvertToUpper(string s)
        {
            StringBuilder sb = new StringBuilder(s.Length);
            if (s.Length > 0)
            {
                char[] ch = s.ToCharArray();
                for (int i = 0; i < ch.Length; i++)
                {
                    switch (ch[i])
                    {
                        case '0':
                            ch[i] = '零';
                            break;
                        case '1':
                            ch[i] = '一';
                            break;
                        case '2':
                            ch[i] = '二';
                            break;
                        case '3':
                            ch[i] = '三';
                            break;
                        case '4':
                            ch[i] = '四';
                            break;
                        case '5':
                            ch[i] = '五';
                            break;
                        case '6':
                            ch[i] = '六';
                            break;
                        case '7':
                            ch[i] = '七';
                            break;
                        case '8':
                            ch[i] = '八';
                            break;
                        case '9':
                            ch[i] = '九';
                            break;
                    }
                    sb.Append(ch[i]);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 字符串去除所有的空格
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static string strQCKG(string str)
        {
            string[] strword = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            str = string.Join("", strword);
            return str;
        }
        static string QCKG(string str)
        {
            StringBuilder sb = new StringBuilder();
            char[] ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i].ToString() == " ")
                    sb.Append(string.Empty);
                else
                    sb.Append(ch[i].ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// 冒泡排序方法重载
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int[] MPPX(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        static double[] MPPX(double[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        double temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

        /// <summary>
        /// 求平均值，四舍五入
        /// </summary>
        /// <param name="arrint"></param>
        /// <returns></returns>
        static double GetAvg(int[] arrint)
        {
            int sum = 0;
            for (int k = 0; k < arrint.Length; k++)
                sum += arrint[k];
            return Math.Round((double)sum / arrint.Length, 2);
        }
        /// <summary>
        /// 判断是是否是质数
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static bool Iszhishu(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// 计算两个数的最大值方法1(重载)
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static int GetnumMax(int num1, int num2)
        {
            int maxnum;
            maxnum = (num1 > num2 ? num1 : num2);
            return maxnum;
        }
        /// <summary>
        /// 计算两个数的最大值方法2(重载)
        /// </summary>
        /// <param name="ps"></param>
        /// <returns></returns>
        static int GetnumMax(params int[] ps)
        {
            int maxnum = ps[0];
            for (int i = 1; i < ps.Length; i++)
            {
                if (maxnum <= ps[i])
                    maxnum = ps[i];
            }
            return maxnum;
        }

        /// <summary>
        /// 求数组的最大值
        /// </summary>
        /// <param name="tarr"></param>
        /// <returns></returns>
        static int GetMax(int[] tarr)
        {
            int max = tarr[0];
            if (tarr != null)
            {
                for (int i = 0; i < tarr.Length; i++)
                {
                    if (max < tarr[i])
                        max = tarr[i];
                }
            }
            return max;
        }
        static double GetMax(double[] tarr)
        {
            double max = tarr[0];
            if (tarr != null)
            {
                for (int i = 0; i < tarr.Length; i++)
                    max = (tarr[i] > max) ? tarr[i] : max;
            }
            return max;
        }


        /// <summary>
        /// 散列排序(哈希排序)
        /// </summary>
        /// <param name="tArry"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public static int[] GetLXSort(int[] tArry, int flag)
        {
            int[] temp = new int[GetMax(tArry) + 1];   //GetMax()方法是计算数组最大值
            for (int i = 0; i < tArry.Length; i++)
                temp[tArry[i]] = flag;
            return temp;
        }

    }

    //-------------------类部分------------------
    //索引器1
    public class InternalIndex
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        //创建索引器
        private List<InternalIndex> l = new List<InternalIndex>();
        public String this[int id, string name]
        {
            get
            {
                return (this[id, name] + this[id, name]).ToString();
            }
            set
            {
                this[id, name] = value;
            }
        }

        public List<InternalIndex> addList(InternalIndex its)
        {
            l.Add(its);
            return l;
        }

    }

    //索引器2
    public class indexs
    {
        private string[] _name = { "张三", "李四", "王武", "赵柳" };
        public int counts   //添加一个count属性
        {
            get { return this._name.Length; }
        }
        //索引器其实是一个特殊的属性,(索引器可以重载,也可以有多个参数)
        public string this[int index]
        {
            get
            {
                if (index <= counts && index > 0)
                    return this._name[index];
                else
                    return null;
            }
            set
            {
                this._name[index] = value;
            }
        }
        //索引器重载(只读索引器)
        public string this[string name]
        {
            get
            {
                if (this._name.Contains(name))
                    return name;
                else
                    return null;
            }
        }
    }

    //多态
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
        public override string ToString() => this.Name + "," + this.Sex + "," + this.Age;

        //定义一个方法
        public void SayHi() => Console.WriteLine("Hi...我是人类。。。");
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

    //自定义泛型类
    public class MyType<T>   //单个自定义泛型类
    {
        //非泛型方法
        void SayHi(T t) => Console.WriteLine(t);
        //泛型方法
        void Sayhello<K>(K k1) => Console.WriteLine(k1);
    }
    public class YouType<T, K, F> where T : struct   //多个自定义泛型类，where关键字 泛型约束（struct:值类型，class:引用类型）
    {
        void SayHi(T t1, K k1, F f1) => Console.WriteLine(t1 + " " + k1 + " " + f1);
    }

    //泛型接口
    public interface IEatable<T, K>   //两个参数类型的泛型接口
    {
        T Say(T msg);
        void Show(T msg, K ko);
    }
    //普通类实现泛型接口
    public class jiekou : IEatable<string, int>
    {
        public string Say(string msg) => msg;
        public void Show(string msg, int ko) => Console.WriteLine(msg + ko);
    }
    //泛型类实现泛型接口
    public class jiekouF<A, B> : IEatable<A, B>    //使用泛型类的类型类型来替代泛型接口的参数类型
    {
        public A Say(A msg) => msg;
        public void Show(A msg, B ko) => Console.WriteLine(msg + "" + ko);
    }


    //单例模式 --- 举例
    public class Simple
    {
        private static Simple _sim = null;
        public static Simple sim
        {
            get
            {
                if (_sim == null)
                    return new Simple();
                return _sim;
            }
        }

        //public static Simple GetSim()
        //{
        //    if (_sim == null)
        //        _sim = new Simple();
        //    return _sim;
        //}
    }

    public class A
    {
        public void Test() => Console.WriteLine("我是a中的Test方法");
        public virtual void Test1() => Console.WriteLine("我是a中的Test1方法");
    }

    public class A1 : A
    {
        public new void Test() => Console.WriteLine("我是a1中的Test方法");
        public override void Test1() => Console.WriteLine("我是a1中的Test1方法");
    }

    public class A2 : A
    {
        public new void Test() => Console.WriteLine("我是a2中的Test方法");
        public override void Test1() => Console.WriteLine("我是a2中的Test1方法");
    }

}
