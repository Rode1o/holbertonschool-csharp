using System;
using System.Collections.Generic;

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

/// <summary>This is Interact.</summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>This is Interact.</summary>
    public int durability{ get; set; }
    /// <summary>This is Interact.</summary>
    public bool isQuestItem;

    /// <summary>This is Interact.</summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>This is Interact.</summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else
        {
            if (isQuestItem)
            {
                Console.WriteLine($"You look at the {name}. There's a key inside.");
            }
            else
            {
                Console.WriteLine($"You look at the {name}. Not much to see here.");
            }
        }
    }

    /// <summary>This is Interact.</summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if(durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else if(durability < 0)
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}

/// <summary>This is Interact.</summary>
public class Key : Base, ICollectable
{
    /// <summary>This is Interact.</summary>
    public bool isCollected{get; set;}
    /// <summary>This is Interact.</summary>
    public Key(string name = "key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>This is Interact.</summary>
    public void Collect()
    {
        if (!isCollected)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else if (isCollected)
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}

///<summary>This class correponds to a Door object.</summary>
public class RoomObjects
{
    ///<summary>This method allows iteraction with the methods within the objects.</summary>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (var element in roomObjects)
        {
            if (type.ToString() == "IInteractive")
            {
                if (element is IInteractive)
                {
                    IInteractive tmp = element as IInteractive;
                    tmp.Interact();
                }
            }
            else if (type.ToString() == "IBreakable")
            {
                if (element is IBreakable)
                {
                    IBreakable tmp = element as IBreakable;
                    tmp.Break();
                }
            }
            else if (type.ToString() == "ICollectable")
            {
                if (element is ICollectable)
                {
                    ICollectable tmp = element as ICollectable;
                    tmp.Collect();
                }
            }
        }
    }
}
