using System;

/// <summary>This is Interact.</summary>
public class Player
{
    /// <summary>This is name string variable.</summary>
    public string name;

    /// <summary>This is maxHP float variable.</summary>
    public float maxHp;

    /// <summary>This is hp float variable.</summary>
    public float hp;

    /// <summary>This is Player constructor.</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        this.maxHp = maxHp;

        if (maxHp > 0)
        {
            this.hp = maxHp;
        }
        else
        {
            this.maxHp = 100f;
            this.hp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
    }

    /// <summary>This is PrintHealth Method.</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
