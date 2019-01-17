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
            int i, j, n, end = 0, fi, max = 1000000;
            float fi_n = 0, buf;
            string buffer;
            bool var = true;
            for (n = 10000; n != 1000000; n++)
            {
                buffer = "";
                fi = 1;
                //Console.WriteLine(n);
                for (i = 2; i != n; i++)
                {
                    if (n % i != 0)
                    {
                        var = true;
                        j = 2;
                        while (var == true)
                        {
                            if(n % j == 0 && i % j == 0)
                            {
                                var = false;
                            } else if (j == 10)
                            {
                                var = false;
                                buffer += i.ToString() + " ";
                                fi++;
                            }
                            j++;
                        }
                    }
                }
                buf = n / fi;
                if(buf > fi_n) { fi_n = buf; end = n; Console.WriteLine("{0}\t| {1}", end, fi_n); }
            }
            
            Console.ReadLine();
        }
    }
}
