using System;

/// <summary>This is a CalculateModifier(float baseValue, Modifier modifier) delegate.</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>This is a CalculateHealth() delegate.</summary>
public delegate float CalculateHealth();

/// <summary>This is a delegate.</summary>
public enum Modifier{
    /// <summary>This is a delegate.</summary>
    Weak,
    /// <summary>This is a delegate.</summary>
    Base,
    /// <summary>This is a delegate.</summary>
    Strong
}

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
    private string status;
    EventHandler<CurrentHPArgs> HPCheck;
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
		this.status = $"{name} is ready to go!";
        HPCheck += CheckStatus;
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

        OnCheckStatus(new CurrentHPArgs(this.hp));
    }

    /// <summary>This is ApplyModifier(float baseValue, Modifier modifier) Method.</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        float returnValue = baseValue;
        if (modifier == Modifier.Weak)
            returnValue *= 0.5f;
        else if (modifier == Modifier.Strong)
            returnValue *= 1.5f;
        return(returnValue);
    }

    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
            this.status = $"{name} is in perfect health!";
        else if (e.currentHp >= (this.maxHp * 0.5f) && e.currentHp < this.maxHp)
            this.status = $"{name} is doing well!";
        else if (e.currentHp >= (this.maxHp * 0.25f) && e.currentHp < (this.maxHp * 0.5f))
            this.status = $"{name} isn't doing too great...";
        else if (e.currentHp > 0f && e.currentHp < (this.maxHp * 0.25f))
            this.status = $"{name} needs help!";
        else if (e.currentHp == 0)
            this.status = $"{name} is knocked out!";

        Console.WriteLine(this.status);
    }

    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
            Console.WriteLine($"Health has reached zero!");
        else
            Console.WriteLine($"Health is low!");
    }

    private void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < (this.maxHp * 0.25f))
            HPCheck += HPValueWarning;

        HPCheck(this, e);
    }
}

/// <summary>This is ValidateHP(float newHp) Method.</summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>This is currentHp.</summary>
    public readonly float currentHp;

    /// <summary>This is CurrentHPArgs constructor.</summary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}
