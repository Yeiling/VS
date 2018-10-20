using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.Linq;
using System.Data;
using System.Xml;
using System.Xml.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linq是.NET4.0以后的的特性，主要是实现对内存中的数据的查询和分析
            //Linq提供统一的编程方式来分析其他外部数据
            #region linq示例
            //int[] arry = { 3, 0, 5, 2, 8, 4, 1, 9, 7, 6 };
            //ArrCsharp(arry);
            //ArrLinq(arry);
            #endregion

            #region LinQ多条件查询(亦可以使用多个where条件)
            //int[] nums = { 6, 27, 20, 18, 50, 49, 98, 51 };
            //var num = from val in nums
            //           where val % 2 == 0 && val<=60  //val小于等于60且为偶数的集合
            //           select val;

            //int i = num.Count();  //个数
            //int max = num.Max();  //最大值
            //int min = num.Min();  //最小值
            //int sum = num.Sum();  //总和
            //double avg = num.Average(); //平均值
            //Console.WriteLine("总共有{0}个,最大值是{1},最小值是{2},总和是{3},平均数是{4}", i, max, min, sum, avg);
            //var temp = (from tp in nums
            //            where tp % 2 == 1
            //            select tp).First();

            //Console.WriteLine("数组的第一奇数是{0}", temp);
            //foreach (int m in num)
            //{
            //    Console.WriteLine(m);
            //}
            #endregion

            #region group...by使用
            //int[] arr = { 3, 90, 179, 49, 51, 88, 102, 22, 70 };
            //var query = from member in arr
            //            orderby member % 3
            //            group member by member % 3;   //按照member%3的结果分组

            //foreach (var v in query)
            //{
            //    Console.WriteLine("%3={0}的元素有：", v.Key);
            //    foreach (var w in v)
            //    {
            //        Console.WriteLine(w);
            //    }
            //}
            #endregion

            #region 用into子句缓存查询结果
            //int[] alb = { 69, 10, 3, 101, 99, 52, 61, 30, 27, 6 };
            //var query1 = from intval in alb
            //             orderby intval
            //             group intval by intval % 3  //按照intval%3的结果分组
            //                 into temp  //将查询结果缓存到temp变量中
            //                 orderby temp.Key  //按缓存的key键排序
            //                 select temp;

            //foreach (var num in query1)
            //{
            //    Console.WriteLine("%3={0}的元素有：", num.Key);
            //    foreach (var k in num)
            //    {
            //        Console.WriteLine(k);
            //    }
            //}
            #endregion

            #region
            //int[] albs = { 69, 10, 3, 101, 99, 52, 61, 30, 27, 6 };
            //ReArr(albs, 5);
            #endregion


            //from和join实现多连接（from连接是全连接，结果相当于笛卡尔集,join连接支持更多高级功能）
            #region 使用from子句实现多个查询连接
            //int[] inval01 = { 3, 7, 1, 50, 30, 90, 61, 7 };
            //int[] inval02 = { 5, 78, 30, 1, 50, 9, 100, 3 };
            //var query01 = from val1 in inval01
            //              from val2 in inval02
            //              where val1 == val2
            //              orderby val1
            //              select new { jihe1 = val1, jihe2 = val2, sum = val1 + val2 };

            //foreach (var num in query01)
            //{
            //    Console.WriteLine(num);
            //    //Console.WriteLine(num.val1 + "=" + num.val2);
            //}
            #endregion

            #region 使用join子句实现内链接
            //int[] inval03 = { 9, 3, 7, 1, 50, 30, 90, 61, 7 };
            //int[] inval04 = { 5, 78, 30, 1, 50, 9, 100, 3, 2 };
            //var query02 = from a in inval03
            //              join b in inval04 on a % 3 equals b
            //              select new { a, b };

            //foreach (var va in query02)
            //{
            //    Console.WriteLine(va);
            //}
            #endregion

            #region 使用join实现分组连接
            //int[] inval05 = { 9, 3, 7, 1, 50, 30, 90, 61, 7, 100 };
            //int[] inval06 = { 5, 78, 30, 1, 50, 9, 100, 3, 2 };
            //var query03 = from num1 in inval05
            //              join num2 in inval06 on num1 equals num2
            //              into temp
            //              select new { val = num1, vall = temp };

            //foreach (var qry in query03)
            //{
            //    foreach (var num in qry.vall)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}
            #endregion

            #region 使用join实现外连接
            //int[] inval07 = { 9, 3, 7, 1, 50, 30, 90, 61, 7, 100 };
            //int[] inval08 = { 5, 78, 30, 1, 50, 9, 100, 3, 2 };
            //var query04 = from a in inval07
            //              join b in inval08 on a equals b
            //              into temp
            //              from val in temp.DefaultIfEmpty()
            //              select new { a, val };

            //foreach (var ele in query04)
            //{
            //    Console.WriteLine(ele);
            //}
            #endregion


            //----------------------------------------------------
            //----------------LinQ语法---Lamda表达式----------------
            //----------------------------------------------------
            #region linQ方法查询（lamda表达式是LinQ方法语法的基本元素）
            //string[] strs = { "abc", "chy", "rck", "stc", "ldw", "sdw", "Cyp" };
            //var result = strs.Where(s => s.Contains('c') || s.Contains('C'));

            //foreach (string str in result)
            //{
            //    Console.WriteLine("包含字母c的字符串有:{0}", str);
            //}

            //int[] arr = { 112, 23, 65, 11, 16, 83, 71, 27, 56 };
            //int sum = arr.Sum();
            //int max = arr.Max();
            //int min = arr.Min();
            //double avg = arr.Average();
            //int count = arr.Count();
            //int first = arr.First(arrs => arrs % 2 == 0); //只有一个参数时，可以省略括号
            //int last = arr.Last((arrs) => arrs % 2 == 0);
            //Console.WriteLine("总和是{0},最大数是{1},最小数是{2},总共{3}个数，平均值是{4},第一个偶数是{5},最后一个偶数是{6}", sum, max, min, count, avg, first, last);
            #endregion

            #region lamda表达式---where()方法,两个重载
            //int[] atr = { 58, 109, 18, 3, 66, 80, 27, 50, 42, 9, 73, 19, 4, 22 };
            ////num表示数据源的每一个元素
            //var res = atr.Where(num => (num > 30 && num < 100));
            //foreach (var vnum in res)
            //{
            //    Console.Write(vnum + " ");
            //}

            //Console.WriteLine();
            ////num是数据源的元素，index是数据源元素的索引
            //res = atr.Where((num, index) => (num >= 30 && num % 2 == 0 && index >= 5));
            //foreach (var num in res)
            //{
            //    Console.Write(num + " ");
            //}
            #endregion

            #region orderby()从小到大和orderbydescending()从大到小
            //int[] arr = { -58, 109, -18, 3, 66, 80, -27, 50, -42, 9, 73, -19, 4, 22 };
            //var a = arr.Where(num => num % 3 == 1).OrderBy(num => num);
            //foreach (var aa in a)
            //{
            //    Console.WriteLine(aa);
            //}
            //Console.WriteLine("----");
            //var b = arr.Where(num => num % 2 == 1).OrderByDescending(num => num);
            //foreach (var bb in b)
            //{
            //    Console.WriteLine(bb);
            //}
            //Console.WriteLine("----");
            ////orderbydescending()方法指定一个自定义的比较器
            //MyComparer mc = new MyComparer();
            //var re = arr.Where(num => num % 2 == 0).OrderByDescending(num => num, mc);
            //foreach (var r in re)
            //{
            //    Console.WriteLine(r);
            //}
            #endregion

            #region Skip()跳过指定数量元素和SkipWhile()跳过满足条件的元素
            //string[] strs = { "abc", "cg", "ldw", "cf", "sdw", "stjt", "A" };
            ////Skip()方法
            //var skip = strs.Skip(3);  //跳过三个元素
            //foreach (string s in skip)
            //{
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine("----");
            ////SkipWhile()方法,不是过滤所有元素，在遇到不满足条件的时候，剩下的元素不再判断
            //var skipwhile = strs.SkipWhile(se => se.Length != 2);
            //foreach (string str in skipwhile)
            //{
            //    Console.WriteLine(str);
            //}
            #endregion

            #region Take()和TakeWhile(),从集合的开始提取满足条件的元素
            //string[] Mystr = { "sc", "rum", "abc", "c", "ldw", "cf", "sdw", "stjt", "A" };
            ////Take()获取集合字符串长度小于等于2的元素个数
            //var takenum = Mystr.Count(ss => ss.Length <= 2);
            //for (int i = 0; i < takenum; i++)  //1：使用for循环获取元素
            //{
            //    Console.WriteLine("集合第{0}个元素是{1}", i, Mystr.ElementAt(i));
            //}
            //Console.WriteLine("--lamda表达式--");
            ////Take()获取集合五个元素（索引从0开始）
            //var take = Mystr.Take(5);
            //int j = 0;
            //foreach (string s in take)   //2：使用foreach获取元素
            //{
            //    Console.WriteLine("第{0}个元素是{1}", j++, s);
            //}
            //Console.WriteLine("--lamda表达式--");
            ////TakeWhile()如果判断条件为true，继续执行下一个元素，如果为false，剩下的元素不再判断
            //var takewhile = Mystr.TakeWhile(str => str.Contains('c') && str.Length >= 2);
            //foreach (string s in takewhile)
            //{
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine("--lamda表达式--");
            //var takewhiles = Mystr.TakeWhile((str, index) => (str.Length >= 2 && index <= 5));
            //foreach (string str in takewhiles)
            //{
            //    Console.WriteLine(str);
            //}
            #endregion

            #region Distinct()方法去除重复的元素
            //double[] drr = { 3.0, 5.0, 6, 1.09, 3.0, 6.0, 7, 8.3, 2.1, 2.1 };
            ////Distinct()方法用去去除集合中重复的元素
            //var distinct = drr.Distinct();
            //foreach (double d in distinct)
            //{
            //    Console.WriteLine(d);
            //}
            #endregion

            #region ConCat()方法连接两个集合
            //int[] arrconcat = { -58, 109, -18, 3, 66, 80, -27, 50, -42, 9, 73, -19, 4, 22 };
            //int[] arr = { 112, 23, 65, 11, 16, 83, 71, 27, 56 };
            //var concats = arrconcat.Concat(arr);
            //foreach (int num in concats)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine("--lamda表达式--");
            //concats = arrconcat.Concat(arr.Where(ints => ints >= 80));
            //foreach (int num in concats)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            #region 集合的交集Intersect()、并集Union()、差集Except()
            //int[] m = { 3, 6, 1, 7, 2, 0, 9, 5, 8 };
            //int[] n = { 6, 0, 3, 1, 8, 10 };
            //var union = m.Union(n);  //并集
            //foreach (var num in union)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine("--lamda表达式--");
            //var intersect = m.Intersect(n);  //交集
            //foreach (var num in intersect)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine("--lamda表达式--");
            //var except = m.Except(n);      //差集 (m集合有，n集合没有的元素)
            //foreach (var num in except)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            //-------------------------------------------------------------
            //----------------------LinQ to DataSet------------------------
            //-------------------------------------------------------------
            //省略(请参考“精通.NET4.0与数据库开发--338页”)
            #region LinQ to DataSet
            //try
            //{
            //    DataSet ds = BuildBook();
            //    DataTable dt = ds.Tables["BookTable"];
            //    var books = from book in dt.AsEnumerable()
            //                where book.Field<double>("BookPrice") >= 90.00
            //                orderby book.Field<double>("BookPrice") descending
            //                select book;
            //    foreach (var b in books)
            //    {
            //        Console.WriteLine("书名:{0},作者:{1},价格:{2}", b.Field<string>("BookName"), b.Field<string>("BookAuthor"), b.Field<double>("BookPrice"));
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //}
            #endregion


            //-------------------------------------------------------------
            //---------------------LinQ to SQL-----------------------------
            #region  LinQ to SQL查询数据方法1
            ////string conn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString();
            //VndMessageDataContext vd = new VndMessageDataContext();
            //Table<VndMessage> t = vd.GetTable<VndMessage>();
            //var result = from vnd in t
            //             where vnd.VndID.Contains("6")
            //             orderby vnd.VndID descending
            //             select vnd;

            //foreach (VndMessage vnd in result)
            //{
            //    Console.WriteLine("编号：{0},名称：{1},邮箱：{2},联系人：{3},电话：{4},地址：{5}", vnd.VndID, vnd.VndName, vnd.Email, vnd.Contacts, vnd.Phone, vnd.Address);
            //    Console.WriteLine("-------------------------------------------------------------------------------");
            //}
            #endregion

            #region LinQ to SQL查询数据方法2
            //VndMessageDataContext vnds = new VndMessageDataContext();
            //foreach (VndMessage vnd in vnds.VndMessage)
            //{
            //    Console.WriteLine("编号：{0},名称：{1},邮箱：{2},联系人：{3},电话：{4},地址：{5}", vnd.VndID, vnd.VndName, vnd.Email, vnd.Contacts, vnd.Phone, vnd.Address);
            //}
            #endregion

            #region LinQ to SQL修改数据
            //Console.WriteLine("请输入供应商编号：");
            //string vndid = Console.ReadLine();
            //if (!string.IsNullOrEmpty(vndid.Trim()))
            //{
            //    VndMessageDataContext vndss = new VndMessageDataContext();
            //    var ids = vndss.VndMessage.SingleOrDefault(vndy => vndy.VndID == vndid);
            //    if (ids == null)
            //    {
            //        Console.WriteLine("没有对应的编号。。。。");
            //    }
            //    else
            //    {
            //        Console.WriteLine("请输入修改后的地址值：");
            //        string address = Console.ReadLine();
            //        if (string.IsNullOrEmpty(address.Trim()))
            //        {
            //            Console.WriteLine("地址不能为空。。。");
            //            //return;
            //        }
            //        try
            //        {
            //            ids.Address = address;
            //            vndss.SubmitChanges(ConflictMode.ContinueOnConflict); //枚举类型的参数
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine(ex.Message.ToString());
            //        }
            //        Console.WriteLine("修改完成，请查看。。。");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("编号不能为空。。。。。");
            //}
            #endregion

            //-----------------------------------------------------
            //---------------------LinQ to XML---------------------
            //-----------------------------------------------------
            #region 使用DOM操作XML文档
            //1:创建一个包含xml文档数据的读取器
            //XmlReader reader = XmlReader.Create(@"D:\VS\NET_BASE\Linq\Book.xml");
            ////2：判断reader的当前读取位置是否在数据流结尾（循环读取）
            //while (!reader.EOF)
            //{
            //    if (reader.Read())
            //    {
            //        if (reader.NodeType == XmlNodeType.Element) //判断读取到的节点类型是一个XmlNodeType元素类型
            //        {
            //            switch (reader.Name)
            //            {
            //                case "bookstore":
            //                    if (reader.MoveToAttribute("count"))
            //                    {
            //                        Console.WriteLine("共有{0}部武侠秘籍", reader.ReadContentAsInt());
            //                    }
            //                    break;
            //                case "book":
            //                    string type = string.Empty, isbn = string.Empty;
            //                    if (reader.MoveToAttribute("type"))
            //                    {
            //                        type = reader.ReadContentAsString();
            //                    }
            //                    if (reader.MoveToAttribute("isbn"))
            //                    {
            //                        isbn = reader.ReadContentAsString();
            //                    }
            //                    Console.WriteLine("编号:{0},类型:{1}", isbn, type);
            //                    break;
            //                case "title":
            //                    Console.WriteLine("书名:{0}", reader.ReadElementContentAsString());
            //                    break;
            //                case "anther":
            //                    Console.WriteLine("作者:{0}", reader.ReadElementContentAsString());
            //                    break;
            //                case "price":
            //                    Console.WriteLine("价格:{0}", reader.ReadElementContentAsDouble());
            //                    break;
            //            }
            //        }
            //    }
            //}
            //reader.Close();  //关闭xml读取流
            #endregion

            //XElement类创建XML元素
            #region 使用xelement创建元素
            ////通过指定元素名称来创建元素
            //XElement eleList = new XElement("List");
            //Console.WriteLine("eleList:{0}", eleList);
            ////通过指定元素创建相同的XML元素
            //XElement eList = new XElement(eleList);  //eleList为已经创建好的元素
            //Console.WriteLine("eList:{0}", eList);

            //XElement li = new XElement("UserName", new { name = "张三", sex = "男", age = 19 });
            //Console.WriteLine("{0}", li);
            #endregion


            //加载XML文件中的所有元素
            #region XML文件中的所有元素
            //XElement xelement = XElement.Load(@"D:\VS\NET_BASE\Linq\Book.xml");
            ////查询xelement中的元素
            //var books = from b in xelement.Elements()
            //            orderby b.Attribute("title")
            //            select b;
            //foreach (var book in books)
            //{
            //    Console.WriteLine(book);
            //}

            //var varbooks = from bs in xelement.Elements("book")
            //               select bs;
            //foreach (var bk in varbooks)
            //{
            //    Console.WriteLine(bk);
            //}
            #endregion

            #region
            //XElement e = new XElement("UserLists", new object[] { "张云", '男', 23, "广东广州" });
            //var users = from user in e.Elements()
            //            select user;
            //try
            //{
            //    if (users != null)
            //    {
            //        if (users.Count() > 0)
            //        {
            //            foreach (var u in users)
            //            {
            //                Console.WriteLine(u);
            //            }
            //        }
            //        else
            //        {
            //            throw new Exception("User列表数量是" + users.Count());
            //        }
            //    }
            //    else
            //    {
            //        throw new Exception("User列表数量为NULL");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message.ToString());
            //}
            #endregion






            Console.ReadKey();
        }

        //----------------方法部分-------------
        //将数组invals的每一项求余
        static void ReArr(int[] invals, int cs)
        {
            if (cs <= 0)
            {
                return;
            }
            if (invals != null)
            {
                for (int i = 0; i < invals.Length; i++)
                {
                    Console.WriteLine(invals[i] + "%" + cs + "={0}", invals[i] % cs);
                }
            }
            else
            {
                return;
            }
        }
        //将数组中的数组+1，并且从大到小排列
        //1：常规的C#语言写法
        static void ArrCsharp(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 1;
            }

            Array.Sort(arr);
            Array.Reverse(arr);
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
        }
        //2：使用LinQ写法
        static void ArrLinq(int[] arr)
        {
            var result = from val in arr
                         orderby val descending   //按照逆序排列
                         select val + 1;    //每一个元素加1

            foreach (int num in result)
            {
                Console.WriteLine(num);
            }
        }
        //LinQ to DataSet创建一个返回值为dataset的方法（仅作练习使用）
        static DataSet BuildBook()
        {
            string[] bookname = { "三国演义", "水浒传", "红楼梦", "西游记" };
            string[] bookauthor = { "罗贯中", "施耐庵", "曹雪芹", "吴承恩" };
            double[] bookprice = { 129.00, 99.00, 159.00, 100.00 };
            DataSet ds = new DataSet("BookSet");
            DataTable dt = new DataTable("BookTable");
            ds.Tables.Add(dt);

            dt.Columns.AddRange(new DataColumn[] { 
                new DataColumn("BookName",typeof(string)),
                new DataColumn("BookAuthor",typeof(string)),
                new DataColumn("BookPrice",typeof(double))
            });

            for (int i = 0; i < bookname.Length; i++)
            {
                DataRow row = dt.NewRow();
                row["BookName"] = bookname[i];
                row["BookAuthor"] = bookauthor[i];
                row["BookPrice"] = bookprice[i];

                dt.Rows.Add(row);
            }

            return ds;
        }
    }
    //-----------------类部分--------------------
    //MyComparer类---实现接口IComparable<T>, IComparer<T>
    class MyComparer : IComparable<int>, IComparer<int>
    {
        public int CompareTo(int other)
        {
            if (other <= 0)
                return 1;
            else
                return 0;

        }
        public int Compare(int x, int y)
        {
            x = Math.Abs(x);
            y = Math.Abs(y);

            if (x > y)
                return 1;
            else if (x == y)
                return 0;
            else
                return -1;

        }
    }

}
