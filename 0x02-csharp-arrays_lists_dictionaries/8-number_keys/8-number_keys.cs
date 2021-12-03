using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int total_keys = 0;

        foreach (var item in myDict)
        {
            total_keys += 1;
        }
        return (total_keys);
    }
}
