using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> remove_node = myLList.First;
        var count = 0;

        while (remove_node != null)
        {
            if (count == index)
            {
                myLList.Remove(remove_node);
            }
            remove_node = remove_node.Next;
            count++;
        }
    }
}
