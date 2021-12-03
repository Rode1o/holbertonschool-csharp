using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int lastdigit = number % 10;

        Console.Write("The last digit of {0} is ", number);
        if (lastdigit > 5)
        {
          Console.WriteLine("{0} and is greater than 5", lastdigit);
        }
        else if (lastdigit == 0)
        {
          Console.WriteLine("{0} and is 0", lastdigit);
        }
        else if (lastdigit < 6)
        {
          Console.WriteLine("{0} and is less than 6 and not 0", lastdigit);
        }
    }
}