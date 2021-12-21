using System;

/// <summary> Class Shape. </summary>
class Shape
{
    /// <summary> The exception that is thrown when a requested method or operation is not implemented. </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
