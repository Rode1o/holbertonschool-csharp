using System;

class Int
{
    public static void divide(int a, int b)
    {
        int result = 0;
        try
        {
            result = a / b;
        }
        catch (Exception)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, result);
        }
    }
}
