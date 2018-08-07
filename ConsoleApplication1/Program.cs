using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //输出9*9乘法表
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    Console.WriteLine(a+"*"+b+"="+a*b);
                }
            }
            Console.ReadKey();
        }
    }
}
