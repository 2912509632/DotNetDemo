using System;
using System.Linq;
using System.Xml.Linq;

namespace 删除指定节点
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
            //LINQ删除指定节点
            doc.Descendants().Where(x => x.Value == "Gogogo").Remove();
            Console.WriteLine("节点删除成功！");
            //查询删除后的节点
            var query = doc.Element("Root").Descendants();

            //展示数据
            foreach (XElement v in query)
                Console.WriteLine("Name：" + v.Value);
        }
    }
}
