using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int lastdigit = 0;

        if (number < 0)
        {
            lastdigit = ((number % 10) * -1);
        }
        else
        {
            lastdigit = number % 10;
        }
        Console.Write(lastdigit);
        return(lastdigit);
    }
}
