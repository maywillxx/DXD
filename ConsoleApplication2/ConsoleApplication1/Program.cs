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
            //兔子繁殖问题。设有一对新生的兔子，从第三个月开始他们每个月都生一对兔子，新生的兔子从第三个月开始又每个月生一对兔子。按此规律，并假定兔子没有死亡，20个月后共有多少个兔子？
            int sum = 0;
            for (int m = 1; m <= 20; m++)
            {
                if (m >= 3)
                {
                    sum++;
                }
            }
        }
    }
}
