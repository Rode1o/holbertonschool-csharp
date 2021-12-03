using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> collection =  new HashSet<int>(myList);
        int total = 0;

        foreach (int j in collection)
        {
            total += j;
        }
        return (total);
    }
}
