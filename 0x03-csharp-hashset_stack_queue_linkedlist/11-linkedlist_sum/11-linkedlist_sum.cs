using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        var total = 0;

        foreach (int i in myLList)
        {
            total = total + i;
        }
        return (total);
    }
}
