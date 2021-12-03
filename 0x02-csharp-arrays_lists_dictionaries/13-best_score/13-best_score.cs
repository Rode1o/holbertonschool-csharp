using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string key = "";
        int value = 0;

        if (myList.Count == 0)
        {
            return ("None");
        }

        foreach (KeyValuePair<string, int> item in myList)
        {
            if (item.Value >= value)
            {
                key = item.Key;
                value = item.Value;
            }
        }
        return (key);
    }
}
