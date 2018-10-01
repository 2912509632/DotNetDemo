using System;
using System.Linq;

namespace LinQToObject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = new string[] { "Hello","What","Where","How","When","GoGoGo"};

            //查询
            var query = from x in data
                        where x.Length>4
                        select x;

            //展示数据
            foreach (string s in query)
                Console.WriteLine(s);
        }
    }
}
