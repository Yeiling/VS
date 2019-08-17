using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace XML
{
    public class XMLHelper
    {

        /// <summary>
        /// 创建XmlDocument文档
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="root">XML根节点---与XML文档名称同名</param>
        public static void CreateXmlDoc(string path, string root)
        {
            //XML文档对象
            XmlDocument doc = new XmlDocument();
            //添加XML头部描述
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", "utf-8", null));
            //XML必须有且仅有一个根节点
            XmlElement Root = doc.CreateElement(root);
            doc.AppendChild(Root);

            for (int i = 0; i < 10; i++)
            {
                var child = doc.CreateElement("name");
                child.InnerText = i.ToString();
                Root.AppendChild(child);
            }


            //保存XML文档
            doc.Save(path + root);
        }

        /// <summary>
        /// 读取XML文档
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string ReadXMLDoc(string path)
        {
            return null;
        }
    }
}
