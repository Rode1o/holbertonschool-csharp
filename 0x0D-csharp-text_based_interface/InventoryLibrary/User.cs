using System;
using System.Collections;

///<summary>User class that inherits from BaseClass.</summary>
public class User : BaseClass
{
    ///<summary>Name of user.</summary>
    public string name { get; set; }

    ///<summary>User constructor.</summary>
    public User(string name)
    {
        this.name = name;
    }
}