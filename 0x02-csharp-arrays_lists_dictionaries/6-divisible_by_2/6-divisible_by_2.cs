using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> new_list = new List<bool>();

        foreach (int i in myList)
        {
            new_list.Add(i % 2 == 0 ? true : false);
        }
        return (new_list);
    }
}
