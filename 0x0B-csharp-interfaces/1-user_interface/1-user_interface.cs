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

/// <summary>
/// This is Queue.
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>This is durability implemented int.</summary>
    public int durability{ get => throw new NotImplementedException() ; set => throw new NotImplementedException(); }
    /// <summary>This is isCollected implemented bool.</summary>
    public bool isCollected{ get => throw new NotImplementedException() ; set => throw new NotImplementedException(); }
    /// <summary>This is Interact.</summary>
    public void Interact()
    {
        throw new NotImplementedException();
    }

    /// <summary>This is break.</summary>
    public void Break()
    {
        throw new NotImplementedException();
    }

    /// <summary>This is Collect.</summary>
    public void Collect()
    {
        throw new NotImplementedException();
    }
}
