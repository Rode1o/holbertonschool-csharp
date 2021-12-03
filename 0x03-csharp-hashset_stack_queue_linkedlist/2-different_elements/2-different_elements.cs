using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> first_list = list1.FindAll(x => !list2.Contains(x)); //Different Elements of list1
        List<int> second_list = list2.FindAll(x => !list1.Contains(x)); //Different Elements of list2

        first_list.AddRange(second_list); // AddRange method in lists adds an entire collection of elements (Concatenates both lists).
        first_list.Sort(); //Order list values

        return (first_list);
    }
}
