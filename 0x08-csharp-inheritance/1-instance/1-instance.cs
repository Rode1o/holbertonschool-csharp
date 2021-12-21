using System;
using System.Collections.Generic;

///<summary> Obj class. </summary>
class Obj
{
    /// <summary> Prototype. </summary>
    /// <param name="obj"> Object. </param>
    /// <returns> True if the object is an instance of, or if the object is an instance of a class that inherited from, Array, otherwise return False. </returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return (typeof(Array).IsInstanceOfType(obj));
    }
}
