using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2500, i = 0, schet, min = 9999999;
            bool c = true;
            while(c == true)
            {
                a++;
                schet = 0;
                for (i = 1; i < 21; i++)
                {
                    if (a % i != 0) i = 21;
                    if (a % i == 0)
                    {
                        schet++;
                    }
                    if (schet == 20)
                    {
                        c = false;
                        min = a;
                    }
                }
            }
            Console.WriteLine("{0}", min);
            Console.ReadLine();
        }
    }
}
