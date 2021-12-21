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

/// <summary> Class Rectangle that inherits from Shape. </summary>
class Rectangle : Shape
{
    // Private fields
    private int width;
    private int height;

    // public properties
    public int Width
    {
        get
        {
            return (width);
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }
    public int Height
    {
        get
        {
            return (height);
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }
}
