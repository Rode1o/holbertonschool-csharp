using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        if (myDict.ContainsKey(key))
        {
            // Replace
            myDict[key] = value;
        }
        else
        {
            // Add
            myDict.Add(key, value);
        }
        return (myDict);
    }
}
