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
            //600851475143
            long numb = 600851475143, i = 0, max = 0, p = 1, buf = 0;
            bool var = true, easy = true;
            i = 1;
            while (var == true)
            {
                p++;
                //Console.WriteLine(p);
                easy = true;
                while (p != 0 && numb % p == 0 && easy == true)
                {
                    i = 1;
                    buf = 0;
                    while (easy == true)
                    {
                        i++;
                        if (p % i == 0 && i != 1 && i != p) easy = false;
                        if (p > max) buf = p;
                        if (i == p) { max = buf; //var = false;
                            easy = false; Console.WriteLine("max = {0}", max); };
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
