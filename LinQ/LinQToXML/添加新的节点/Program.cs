using System;
using System.Xml.Linq;


namespace 添加新的节点
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

            //LINQ添加新的节点
            doc.Element("Root").Add(new XElement("Name", "NewLine1"));
            doc.Element("Root").Add(new XElement("Name", "NewLine2"));
            doc.Element("Root").Add(new XElement("Name", "NewLine3"));

            //查询数据
            var query = doc.Element("Root").Descendants();

            //展示数据
            foreach (XElement v in query)
                Console.WriteLine("Name：" + v.Value);
        }
    }
}
