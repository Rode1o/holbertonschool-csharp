using System;
using System.Collections.Generic;
class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> linked_list = new LinkedList<int>();

        if (size < 0)
        {
            return (linked_list);
        }

        for (int i = 0; i < size; i++)
        {
            linked_list.AddFirst(i);
            Console.WriteLine(i);
        }
        return (linked_list);
    }
}
