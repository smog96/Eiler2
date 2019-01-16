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
            int i, p = 1, max = 0, buf = 0, count = 0;
            bool var = true, easy;
            while (var == true)
            {
                easy = true;
                p++;
                i = 0;
                //while (easy == true)
                //{
                //    i++;
                //    if (i != p && p % i == 0) easy = false;
                //    if (i != p && p % i != 0)
                //    {
                //        easy = false;
                //        count++;
                //        if (p > max) max = p;
                //        Console.WriteLine(p);
                //    }
                //}
                while (easy == true)
                {
                    i++;
                    if (p % i == 0 && i != 1 && i != p) easy = false;
                    if (p > max) buf = p;
                    if (i - 1 == p)
                    {
                        max = buf;
                        count++;
                        easy = false;
                        Console.WriteLine("{0}", max);
                    };
                }
                if (count == 10001) var = false;
            }
            Console.WriteLine("10001 point = {0}", max);
            Console.ReadLine();
        }
    }
}
