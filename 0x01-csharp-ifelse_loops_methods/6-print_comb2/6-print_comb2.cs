using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            for (int i = 0; i <= 8; i++)
            {
                for (j = 0; j <= 9; j++)
                {
                    if (i < j)
                    {
                        if (i != 8 || j != 9)
                        {
                            Console.Write("{0}{1}, ", i, j);
                        }
                        else
                        {
                            Console.Write("{0}{1}\n", i, j);
                        }
                    }
                }
            }
        }
    }
}
