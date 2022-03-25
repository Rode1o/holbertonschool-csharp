using System;

/// <summary>This is Interact.</summary>
public class Player
{
    /// <summary>This is a delegate.</summary>
    public delegate float CalculateHealth();

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

    /// <summary>This is TakeDamege(float damage) Method.</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            Console.WriteLine($"{name} takes 0 damage!");
        else
        {
            Console.WriteLine($"{name} takes {damage} damage!");
            ValidateHP(hp -= damage);
        }
    }

    /// <summary>This is HealDamage(float heal) Method.</summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            Console.WriteLine($"{name} heals 0 HP!");
        else
        {
            Console.WriteLine($"{name} heals {heal} HP!");
            ValidateHP(hp += heal);
        }
    }

    /// <summary>This is ValidateHP(float newHp) Method.</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            hp = 0;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;
    }
}
