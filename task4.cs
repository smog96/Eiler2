namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, i, j, schet = 0, max = 0;
            string x;
            
            for (a = 100; a < 999; a++)
            {
                for (b = 100; b < 999; b++)
                {
                    c = a * b;
                    x = Convert.ToString(c);
                    j = x.Length - 1;
                    i = 0;
                    schet = 0;
                    while (x[i] == x[j] && i != j)
                    {
                        if (x[i] == x[j]) schet += 2;
                        if (schet == x.Length && c > max) max = c;
                        i++;j--;
                        if (i > x.Length || j < 0) i = j = 0;
                    }
                }
            }
            Console.WriteLine("max = {0}", max);
            Console.ReadLine();
        }
    }
}
