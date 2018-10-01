using System;
using System.Xml.Linq;

namespace 读取XML文档
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化XML
            string xml = @"<Root><Name>Hello</Name><Name>World</Name><Name>Welcome</Name><Name>HereHere</Name><Name>Gogogo</Name></Root>";
            //加载XML
            XDocument doc = new XDocument();
            doc = XDocument.Parse(xml);
            //LINQ读取XML节点
            var query = doc.Elements("Root").Descendants();

            //展示数据
            foreach (XElement v in query)
                Console.WriteLine("Name："+v.Value);
        }
    }
}
