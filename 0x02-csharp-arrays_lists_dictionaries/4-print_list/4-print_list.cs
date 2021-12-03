using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int> list_completed;

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }
        list_completed = new List<int>(size);
        
        if (size == 0)
        {
            Console.Write("\n");
            return (list_completed);
        }

        for (int i = 0; i < size; i++)
        {
            list_completed.Add(i);
            Console.Write("{0}{1}", i, i == size -1 ? "\n" : " ");
        }
        return (list_completed);
    }
}
