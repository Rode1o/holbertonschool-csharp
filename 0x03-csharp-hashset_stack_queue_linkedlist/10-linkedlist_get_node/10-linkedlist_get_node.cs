using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        var container = 0;

        foreach (int i in myLList)
        {
            if (container == n)
            {
                return (i);
            }
            container++;
        }
        return (0);
    }
}
