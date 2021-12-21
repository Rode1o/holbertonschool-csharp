using System;
using System.Collections.Generic;

///<summary> Public class. </summary>
class Obj
{
    /// <summary> Prototype. </summary>
    /// <param name="obj"> Object. </param>
    /// <returns> True if the object is an int, otherwise return False. </returns>
    public static bool IsOfTypeInt(object obj)
    {
        return (obj.GetType() == typeof(int));
    }
}
