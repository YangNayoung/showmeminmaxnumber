using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmeminmaxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0, min = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("숫자를 입력해주세요 : ");
                int input = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    max = input;
                    min = input;
                }
                if (input > max) max = input;
                if (input < min) min = input;
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("가장 큰 수 : " + max);
            Console.WriteLine("가장 작은 수 : " + min);
        }
    }
}
