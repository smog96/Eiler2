using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, buf = 0, num_buf = 0, count = 0;
            long n;
            for(i=999999; i != 0; i--)
            {
                n = i;
                buf = 0;
                while (n != 1)
                {
                    if (n % 2 == 0 && n != 1)
                    {
                        buf++;
                        n = n / 2;
                    }
                    if (n % 2 != 0 && n != 1)
                    {
                        buf++;
                        n = 3 * n + 1;
                    }
                }
                if (buf > count) { num_buf = i; count = buf; Console.WriteLine("Число = {0}, последовательность длинной {1}", num_buf, count); }
            }
            Console.WriteLine("It's over!");
            Console.ReadLine();
        }
    }
}
