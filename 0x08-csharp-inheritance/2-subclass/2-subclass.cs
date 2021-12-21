using System;

class Obj
{
    /// <summary> Prototype. </summary>
    /// <param name="derivedType"> Object (subclass) </param>
    /// <param name="baseType"> Class. </param>
    /// <returns> True if the object is an instance of a class that inherits from the specified class, otherwise return False. </returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return (derivedType.IsSubclassOf(baseType));
    }
}
