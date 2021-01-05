using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static int f(int n) {

            if (n < 1) return n;
            else
                if (n == 1) return 1;
                else
                return 2 * f(n - 1) + 1; 

            //  return 0;
        }

        static void Main(string[] args)
        {
            int a = 3;
            Console.WriteLine(f(a)); // 7
            Console.WriteLine(f(f(3))); // 127

            Console.ReadKey();
        }
    }
}
