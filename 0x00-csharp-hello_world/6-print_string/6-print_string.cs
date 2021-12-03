using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		Console.WriteLine("{0}{0}{0}"+"\n"+"{1}", str, str.Substring(0,9));	
    }
}
