using System;
using System.IO;
using System.Net;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:61787/api/test/getjson";
            string type = "Get";
            Encoding encoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = type.ToUpper().ToString();
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.ContentType = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}
