using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //求出1~1000之间的所有能被7整除的数，并计算和输出每5个的和。
            int sum = 0;
            int count = 0;
            for (int num = 1; num <=1000; num++)
            {
                if (num%7==0)
                {
                    count++;
                    sum += num;
                    if (count == 5)
                    {
                        Console.WriteLine(sum);
                        count = 0;
                        sum = 0;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
