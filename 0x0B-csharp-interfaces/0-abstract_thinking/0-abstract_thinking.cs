using System;

/// <summary>
/// This is Queue.
/// </summary>
public abstract class Base
{
    /// <summary>This is Queue empty class.</summary>
    public string name;

    /// <summary>This is Queue empty class.</summary>
    public override string ToString()
    {
        return($"{name} is a {this.GetType()}");
    }
}
