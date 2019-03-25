using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            //A:使用DOM操作XML
            //0.1：XmlReader读取xml文件---静态解析(快速高效，并且可扩展，缺点是只读)
            #region XmlReader读取文件（按节点的顺序依次读取）
            ////定义一个XmlReader对象
            //XmlReader reader = XmlReader.Create(@"D:\VS\NET_BASE\XML\Province.xml");
            ////判断是否读到了文件的结尾
            //while (!reader.EOF)  //一直读取，直到读到文件结尾
            //{
            //    if (reader.Read())  //读取下一个节点
            //    {
            //        if (reader.NodeType == XmlNodeType.Element)  //判断当前独到的节点类型是否是元素节点
            //        {
            //            switch (reader.Name)  //读取到的节点限定名称
            //            {
            //                case "China":
            //                    string china = reader.Name;
            //                    Console.WriteLine(china + ":");
            //                    break;
            //                case "Province":
            //                    Console.WriteLine();
            //                    string Province = reader.Name, Provincename = string.Empty;
            //                    if (reader.MoveToAttribute("Name"))
            //                    {
            //                        Provincename = reader.ReadContentAsString();
            //                    }
            //                    Console.WriteLine("  " + Province + ":" + Provincename);

            //                    break;
            //                case "City":
            //                    string city = reader.Name, cityname = string.Empty;
            //                    if (reader.MoveToAttribute("Name"))
            //                    {
            //                        cityname = reader.ReadContentAsString();
            //                    }
            //                    Console.WriteLine("    " + city + ":" + cityname);
            //                    break;
            //                case "District":
            //                    string District = reader.Name, Districtname = string.Empty, lon = string.Empty, lat = string.Empty;
            //                    if (reader.MoveToAttribute("Name"))
            //                    {
            //                        Districtname = reader.ReadContentAsString();
            //                    }
            //                    if (reader.MoveToAttribute("Lon"))
            //                    {
            //                        lon = reader.ReadContentAsString();
            //                    }
            //                    if (reader.MoveToAttribute("Lat"))
            //                    {
            //                        lat = reader.ReadContentAsString();
            //                    }
            //                    Console.WriteLine("      " + District + ":" + Districtname + " 经度:" + lon + " 纬度:" + lat);
            //                    break;
            //            }
            //        }
            //    }
            //}
            //reader.Close();
            #endregion
            //0.1.1XmlReader读取XML文件---动态解析
            #region
            //XmlReader r = XmlReader.Create(@"D:\VS\NET_BASE\XML\Province.xml");
            //while (!r.EOF)
            //{
            //    if (r.Read())
            //    {
            //        if (r.NodeType == XmlNodeType.XmlDeclaration)  //声明
            //        {
            //            if (r.AttributeCount > 0)
            //            {
            //                for (int i = 0; i < r.AttributeCount; i++)   //循环当前节点的属性
            //                {
            //                    r.MoveToAttribute(i);
            //                    Console.Write(" 第" + (i + 1) + "个属性:" + r.Name + "值:" + r.Value);
            //                }
            //            }
            //        }
            //        if (r.NodeType == XmlNodeType.Element)        //节点
            //        {
            //            string nodename = r.Name;
            //            StringBuilder sb = new StringBuilder();
            //            if (r.AttributeCount != 0)
            //            {
            //                sb.Append(nodename);
            //                for (int j = 0; j < r.AttributeCount; j++)
            //                {
            //                    r.MoveToAttribute(j);
            //                    sb.Append(" " + r.Name + ":" + r.Value + " ");
            //                }
            //                Console.WriteLine(sb.ToString());
            //                Console.WriteLine();
            //            }
            //            else
            //            {
            //                Console.WriteLine(" " + nodename + " ");
            //            }
            //        }
            //    }
            //}
            //r.Close();
            #endregion
            //Xml_Reader(@"D:\VS\NET_BASE\XML\Book.xml");

            //0.2：XmlWriter写入到xml文件
            #region
            //XmlWriter writer = XmlWriter.Create(@"G:\Book.xml");

            //writer.WriteStartDocument();  //写入文件头，也可以使用WriteComment()方法写入自定义标准头
            //writer.WriteWhitespace(Environment.NewLine);

            //writer.WriteStartElement("bookstore");   //写入根标签
            //writer.WriteWhitespace(Environment.NewLine);

            //for (int k = 1; k <= 100; k++)
            //{
            //    writer.WriteStartElement("book");
            //    writer.WriteWhitespace(Environment.NewLine);

            //    writer.WriteStartElement("ID");
            //    writer.WriteValue(k);

            //    writer.WriteEndElement();
            //    writer.WriteWhitespace(Environment.NewLine);

            //    writer.WriteEndElement();
            //    writer.WriteWhitespace(Environment.NewLine);
            //}
            //writer.WriteEndElement();     //结束根标签
            //writer.WriteWhitespace(Environment.NewLine);

            //writer.WriteEndDocument();     //结束文件头
            //writer.Close();
            #endregion

            //B:XmlDocument和XDocument都可以读取和写入XML文件，它们和XML的序列化是不同的一件事
            //1.1:XmlDocument读取XML文件
            #region
            //XmlDocument xdd = new XmlDocument();
            //xdd.Load(@"G:\VndMessage.xml");
            ////获取根节点bookstore
            //XmlNode xn = xdd.SelectSingleNode("Vnd");
            ////获取根节点的所有子节点
            //XmlNodeList xnl = xn.ChildNodes;
            ////遍历子节点
            //foreach (XmlNode x in xnl)
            //{
            //    if (x.Name == "ChildVnd")
            //    {
            //        Console.WriteLine(x.Attributes["List"].Value);
            //    }
            //}
            #endregion
            //1.2:XmlDocument读取xml文件
            #region
            //XmlDocument doc = new XmlDocument();
            //doc.Load(@"G:\VndMessage.xml");  //加载xml文件
            //XmlElement root = doc.DocumentElement;  //获取根元素

            //XmlNodeList xn = root.ChildNodes;   //获取根节点下的所有子节点
            //foreach (XmlNode x in xn)
            //{
            //    XMLDoc(x);
            //}
            #endregion

            //2.1:XDocument读取xml文件
            #region
            //XDocument xr = XDocument.Load(@"G:\VndMessage.xml");  //加载xml文件
            //XElement root = xr.Root;

            //IEnumerable<XElement> elements = root.Elements();  //获得根节点下的元素集合     
            //foreach (XElement e in elements)
            //{
            //    Console.WriteLine(e.Name + ":" + e.Value);//获得元素名        
            //    DiGuiNode(e);
            //}
            #endregion
            //2.2：使用XmlDocument写XML文件
            #region
            //A:在内存中构建一个XML对象
            //XmlDocument xmldd = new XmlDocument();
            //XmlDeclaration xdeclartion = xmldd.CreateXmlDeclaration("1.0", "utf-8", "yes");  //创建XML文件声明（如：<?xml version="1.0" encoding="utf-8" ?>）
            //xmldd.AppendChild(xdeclartion);

            ////(2):根节点
            //XmlElement Students = xmldd.CreateElement("Students");
            //xmldd.AppendChild(Students);

            ////(3):添加子节点
            //XmlElement stu = xmldd.CreateElement("stu");  //子节点
            //XmlAttribute id = xmldd.CreateAttribute("id");  //子节点的属性
            //id.Value = "001";
            //stu.Attributes.Append(id);   //子节点添加属性
            //Students.AppendChild(stu);   //根节点添加子节点

            //XmlElement name = xmldd.CreateElement("name");
            //name.InnerText = "张三";
            //stu.AppendChild(name);
            //XmlElement sex = xmldd.CreateElement("sex");
            //sex.InnerText = "男";
            //stu.AppendChild(sex);
            //XmlElement age = xmldd.CreateElement("age");
            //age.InnerText = "23";
            //stu.AppendChild(age);
            //XmlElement dept = xmldd.CreateElement("dept");
            //dept.InnerText = "大学英语";
            //stu.AppendChild(dept);

            ////B:将该对象写入XML文件
            //xmldd.Save(@"G:\Students.xml");
            #endregion

            #region 将泛型集合中的数据写入XML文件中
            //string sqlconn = "Server=CAI;Database=Test;Uid=sa;Pwd=123456;";
            //string sql = @"Select VndID,Vndname,Address,Contacts,Phone,Email from VndMessage";
            //List<Vnd> vnds = GetVnd(sqlconn, sql);

            //XmlDocument vndmessage = new XmlDocument();
            //XmlDeclaration dire = vndmessage.CreateXmlDeclaration("1.0", "utf-8", "yes");
            //vndmessage.AppendChild(dire);    //添加文件描述

            //XmlElement root = vndmessage.CreateElement("VndMessage");   //创建一个节点(根节点vnd)
            //vndmessage.AppendChild(root);
            //for (int i = 0; i < vnds.Count; i++)
            //{
            //    XmlElement Child = vndmessage.CreateElement("VndChild");  //子节点
            //    XmlAttribute id = vndmessage.CreateAttribute("List"); //子节点属性
            //    id.InnerText = (i + 1).ToString();   //子节点属性值
            //    Child.Attributes.Append(id);      //添加属性到子节点

            //    root.AppendChild(Child);          //添加子节点到根节点

            //    XmlElement vndid = vndmessage.CreateElement("VndID");   //子节点下添加节点
            //    vndid.InnerText = vnds[i].Vndid.ToString();
            //    Child.AppendChild(vndid);

            //    XmlElement vndname = vndmessage.CreateElement("VndName");
            //    vndname.InnerText = vnds[i].Vndname.ToString();
            //    Child.AppendChild(vndname);

            //    XmlElement contacts = vndmessage.CreateElement("Contacts");
            //    contacts.InnerText = vnds[i].Contacts.ToString();
            //    Child.AppendChild(contacts);

            //    XmlElement phone = vndmessage.CreateElement("Phone");
            //    phone.InnerText = vnds[i].Phone.ToString();
            //    Child.AppendChild(phone);

            //    XmlElement email = vndmessage.CreateElement("Email");
            //    email.InnerText = vnds[i].Email.ToString();
            //    Child.AppendChild(email);

            //    XmlElement address = vndmessage.CreateElement("Address");
            //    address.InnerText = vnds[i].Address.ToString();
            //    Child.AppendChild(address);

            //}
            //vndmessage.Save(@"G:\VndMessage.xml");   //保存XML文档
            //Console.WriteLine("保存成功OK....");
            #endregion

            //2.3：使用XDocument写入XML文件
            #region  从数据库返回泛型集合
            //XDocument xd = new XDocument();
            //XDeclaration declaration = new XDeclaration("1.0", "utf-8", "yes");
            //xd.Declaration = declaration;   //设置文档定义，注意与XmlDocument的区别

            //XElement root = new XElement("VndMessage");  //根节点
            //xd.Add(root);

            //string sqlconn = "Server=CAI;Database=Test;Uid=sa;Pwd=123456;";
            //string sql = @"Select VndID,Vndname,Address,Contacts,Phone,Email from VndMessage";
            //List<Vnd> vnds = GetVnd(sqlconn, sql);

            //for (int j = 0; j < vnds.Count; j++)
            //{
            //    XElement vnd = new XElement("Vnd");   //Vnd节点
            //    vnd.SetAttributeValue("List", (j + 1).ToString());

            //    root.Add(vnd);     //将Vnd节点加到根节点中

            //    XElement vndid = new XElement("VndID");
            //    vndid.Value = vnds[j].Vndid.ToString();
            //    vnd.Add(vndid);

            //    XElement vndname = new XElement("VndName");
            //    vndname.Value = vnds[j].Vndname.ToString();
            //    vnd.Add(vndname);

            //    XElement contacts = new XElement("Contacts");
            //    contacts.Value = vnds[j].Contacts.ToString();
            //    vnd.Add(contacts);

            //    XElement phone = new XElement("Phone");
            //    phone.Value = vnds[j].Phone.ToString();
            //    vnd.Add(phone);

            //    XElement email = new XElement("Email");
            //    email.Value = vnds[j].Email.ToString();
            //    vnd.Add(email);

            //    XElement address = new XElement("Address");
            //    address.Value = vnds[j].Address.ToString();
            //    vnd.Add(address);

            //}
            //xd.Save(@"G:\XD_VndMessage.xml");
            //Console.WriteLine("OK");
            #endregion

            //C:使用XmlDocument和XDocument搜索指定节点
            //3.0：使用XmlDocument搜索节点
            #region 类似于JS中的获取元素
            //XmlDocument xd = new XmlDocument();
            //xd.Load("xml文件");
            //xd.GetElementById("ID名称");
            //XmlNodeList listnode = xd.GetElementsByTagName("tagname");
            //foreach (XmlNode node in listnode)
            //{
            //    //..........
            //}
            #endregion

            //3.1：使用XDocument搜索节点
            #region XDocument获取节点
            //XDocument xx = XDocument.Load("XML文件");
            //XElement r = xx.Root;

            ////获得包含某一个节点名称的节点（适应lumda表达式）
            //IEnumerable<XElement> elements = r.Descendants("节点名称").Where(x => x.Attribute("属性ID").Value == "001");
            //foreach (XElement ele in elements)
            //{
            //    //.........
            //}
            #endregion


            //4:Xpath路径表达式:XML文件根据表达式寻找节点
            //表达式写法（“/Book”：表示根节点下的book标签，“//bobk”:所有带book标签的，“//book/type”所有book标签下的type标签，“/book//type”:根节点下的book标签下的所有type标签，“//book[id="123"]:所有book节点下id=123的那个节点”）
            #region
            //XmlDocument docment = new XmlDocument();
            //docment.Load(@"G:\VndMessage.xml");

            ////----------通过Xpath遍历节点集合--------
            //XmlNodeList Listnodes = docment.SelectNodes("//ChildVnd");  //Xpath表达式
            //foreach (XmlNode no in Listnodes)
            //{
            //    Console.WriteLine(no.Name + ":" + no.Attributes["List"].Value);
            //}

            ////----------通过Xpath遍历节点----------
            //XmlNode node = docment.SelectSingleNode("//ChildVnd");  //Xpath表达式
            //Console.WriteLine(node.Name);
            #endregion


            Console.ReadKey();
        }

        //-----------连接数据库，获取VndMessage信息------
        static List<Vnd> GetVnd(string sqlconn, string sql)
        {
            List<Vnd> Vnds = new List<Vnd>();
            SqlConnection conn = new SqlConnection(sqlconn);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    Vnd v = new Vnd();
                    v.Vndid = string.IsNullOrEmpty(r["VndID"].ToString()) ? string.Empty : r["VndID"].ToString();
                    v.Vndname = string.IsNullOrEmpty(r["VndName"].ToString()) ? string.Empty : r["VndName"].ToString();
                    v.Contacts = string.IsNullOrEmpty(r["Contacts"].ToString()) ? string.Empty : r["Contacts"].ToString();
                    v.Phone = string.IsNullOrEmpty(r["Phone"].ToString()) ? string.Empty : r["Phone"].ToString();
                    v.Email = string.IsNullOrEmpty(r["Email"].ToString()) ? string.Empty : r["Email"].ToString();
                    v.Address = string.IsNullOrEmpty(r["Address"].ToString()) ? string.Empty : r["Address"].ToString();
                    Vnds.Add(v);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return Vnds;
        }

        //XmlDocument读取XML文件（采用递归方式）
        static void XMLDoc(XmlNode node)
        {
            if (node != null)
            {
                XmlNodeList list = node.ChildNodes;
                foreach (XmlNode xn in list)
                {
                    Console.WriteLine(xn.Name + ":" + xn.InnerText);
                    XMLDoc(xn);
                }

            }
        }

        //XDocument读取XML文件（采用递归的方式）
        static void DiGuiNode(XElement xroot)
        {
            if (xroot != null)
            {
                foreach (XElement item in xroot.Elements())
                {
                    Console.WriteLine(item.Name + ":" + item.Value);//获得元素名和基本值
                    DiGuiNode(item);
                }
            }
        }

        //使用XmlReader读取XML文件---动态解析
        static void Xml_Reader(string path)
        {
            XmlReader r = XmlReader.Create(path);
            while (!r.EOF)
            {
                if (r.Read())
                {
                    StringBuilder sb = new StringBuilder();
                    if (r.Value.Contains("\n"))
                    {
                        continue;
                    }
                    if (r.NodeType == XmlNodeType.XmlDeclaration)  //1：声明
                    {
                        if (r.AttributeCount > 0)
                        {
                            for (int i = 0; i < r.AttributeCount; i++)   //循环当前节点的属性
                            {
                                r.MoveToAttribute(i);
                                Console.WriteLine("第" + (i + 1) + "个属性:" + r.Name + "值:" + r.Value);
                            }
                        }
                    }
                    Console.WriteLine();
                    if (r.NodeType == XmlNodeType.Element)        //2：节点
                    {
                        string nodename = r.Name;
                        if (r.AttributeCount != 0)
                        {
                            sb.Append(nodename);
                            for (int j = 0; j < r.AttributeCount; j++)
                            {
                                r.MoveToAttribute(j);
                                sb.Append(r.Name + ":" + r.Value);
                            }
                        }
                        else
                        {
                            sb.Append(nodename);
                        }
                        Console.Write(sb.ToString());
                    }
                    if (r.NodeType == XmlNodeType.Text)   //3：文本内容（节点之间的值）
                    {
                        Console.Write(r.Value);
                    }
                }
            }
            r.Close();
        }


    }
}
