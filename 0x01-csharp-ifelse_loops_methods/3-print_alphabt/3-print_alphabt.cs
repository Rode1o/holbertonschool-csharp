using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                if (i != 'q' && i != 'e')
                {
                    Console.Write(i);
                }
            }
        }
    }
}
