using System;
using System.Collections.Generic;
using System.Reflection;

class Obj
{
    /// <summary> Prints the names of the available properties and methods of an object. </summary>
    /// <param name="myObj"> Object. </param>
    public static void Print(object myObj)
    {
        // Represents type declaration for myObj
        Type obj = myObj.GetType().GetTypeInfo();

        Console.WriteLine("{0} Properties:", obj.Name);
        foreach (PropertyInfo p in obj.GetProperties())
        {
            // Get Properties
            Console.WriteLine(p.Name);
        }

        Console.WriteLine("{0} Methods:", obj.Name);
        foreach (MethodInfo m in obj.GetMethods())
        {
            // Get Methods
            System.Console.WriteLine(m.Name);
        }
    }
}
