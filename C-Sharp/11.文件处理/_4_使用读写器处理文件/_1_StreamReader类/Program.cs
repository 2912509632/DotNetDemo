using System;
using System.Text;
using System.IO;

namespace _1_StreamReader类
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = Directory.GetCurrentDirectory()+"\\Test.txt";
            FileStream stream = new FileStream(test, FileMode.Open, FileAccess.Read, FileShare.None);
            using (StreamReader reader = new StreamReader(stream))
            {
                Console.WriteLine(reader.ReadToEnd());
                //while (!reader.EndOfStream)
                //{
                //    Console.WriteLine(reader.ReadLine());
                //}
            }
        }
    }
}
