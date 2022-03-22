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

/// <summary>
/// This is Queue.
/// </summary>
public interface IInteractive
{
    /// <summary>This is Interact.</summary>
    void Interact();
}

/// <summary>This is Interact.</summary>
public interface IBreakable
{
    /// <summary>This is Interact.</summary>
    int durability{ get; set; }
    /// <summary>This is Interact.</summary>
    void Break();
}

/// <summary>This is Interact.</summary>
public interface ICollectable
{
    /// <summary>This is Interact.</summary>
    bool isCollected{ get; set; }
    /// <summary>This is Interact.</summary>
    void Collect();
}

/// <summary>This is Interact.</summary>
public class Door : Base, IInteractive
{
    /// <summary>This is Interact.</summary>
    public Door(string name = "Door")
    {
        this.name = name;
    }
    /// <summary>This is Interact.</summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
