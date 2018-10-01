using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.二维数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明二维数组
            string [,] arrs;

            //为数组赋值
            arrs=new string[,]{{"1A","1B","1C","1D"},{"2A","2B","2C","2D"},{"3A","3B","3C","3D"}};

            //访问数组元素
            for(int i=0,j=0;i<3&j<4;i++,j++){
                Console.WriteLine("当前输出元素："+arrs[i,j]);
            }
        }
    }
}
