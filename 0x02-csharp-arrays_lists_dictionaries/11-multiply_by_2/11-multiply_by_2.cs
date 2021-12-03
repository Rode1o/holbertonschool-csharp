using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> new_dict = new Dictionary<string, int>(myDict);

        foreach (var item in myDict)
        {
            new_dict[item.Key] = item.Value * 2;
        }
        return (new_dict);
    }
}
