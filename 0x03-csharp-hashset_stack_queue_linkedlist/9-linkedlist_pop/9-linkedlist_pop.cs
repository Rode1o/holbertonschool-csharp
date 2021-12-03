using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        var first_value = 0;

        if (myLList.Count <= 0)
        {
            return (0);
        }
        first_value = myLList.First.Value;
        myLList.RemoveFirst();

        return (first_value);
    }
}
