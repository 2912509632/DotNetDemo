using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 可为空的数据类型
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            if (!a.HasValue)
            {
                bool? b = null;
                Console.WriteLine(b.GetValueOrDefault());
            }
        }
    }
}
