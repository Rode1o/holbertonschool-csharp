using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> common_elements = list1.FindAll(x => list2.Contains(x)); // Bring out the common elements.
        common_elements.Sort(); // Order list.

        return (common_elements);
    }
}
