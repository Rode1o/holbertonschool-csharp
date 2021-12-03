using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string str = "Holberton School";
        Console.WriteLine($"{str}{str}{str}\n{str.Substring(0, 9)}");
    }
}