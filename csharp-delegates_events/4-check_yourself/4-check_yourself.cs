using System;

/// <summary>
/// Enum for different modifier statuses.
/// </summary>
public enum Modifier
{
    /// <summary>
    /// Weak status, applies a reduction to the base value.
    /// </summary>
    Weak,
    /// <summary>
    /// Base status, no change to the base value.
    /// </summary>
    Base,
    /// <summary>
    /// Strong status, applies an increase to the base value.
    /// </summary>
    Strong
}

/// <summary>
/// Delegate to calculate a modified value based on a base value and a modifier.
/// </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Represents a player with health management and status updates.
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status;

    /// <summary>
    /// Event that triggers when the player's health changes.
    /// </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>
    /// Constructor to initialize the properties name and maxHp, and set the initial health.
    /// </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;

        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }
        this.hp = this.maxHp;
        this.status = $"{name} is ready to go!";
        this.HPCheck += CheckStatus;
    }

    /// <summary>
    /// Method to print the player's current health status.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    /// <summary>
    /// Method to apply damage to the player and update health.
    /// </summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
        }
        Console.WriteLine($"{this.name} takes {damage} damage!");
        float newHp = this.hp - damage;
        ValidateHP(newHp);
    }

    /// <summary>
    /// Method to heal the player and update health.
    /// </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }
        Console.WriteLine($"{this.name} heals {heal} HP!");
        float newHp = this.hp + heal;
        ValidateHP(newHp);
    }

    /// <summary>
    /// Method to validate the player's health and trigger the HPCheck event if health changes.
    /// </summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            this.hp = 0;
        }
        else if (newHp > this.maxHp)
        {
            this.hp = this.maxHp;
        }
        else
        {
            this.hp = newHp;
        }

        HPCheck?.Invoke(this, new CurrentHPArgs(this.hp));
    }

    /// <summary>
    /// Method to apply a modifier to a base value and return the modified value.
    /// </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return baseValue / 2;
        }
        else if (modifier == Modifier.Base)
        {
            return baseValue;
        }
        else if (modifier == Modifier.Strong)
        {
            return baseValue * 1.5f;
        }
        return 0;
    }

    /// <summary>
    /// Handles the HPCheck event to update the player's status based on current health.
    /// </summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        float hp = e.currentHP;

        if (hp == this.maxHp)
        {
            this.status = $"{this.name} is in perfect health!";
        }
        else if (hp >= this.maxHp / 2)
        {
            this.status = $"{this.name} is doing well!";
        }
        else if (hp >= this.maxHp / 4)
        {
            this.status = $"{this.name} isn't doing too great...";
        }
        else if (hp > 0)
        {
            this.status = $"{this.name} needs help!";
        }
        else
        {
            this.status = $"{this.name} is knocked out!";
        }

        Console.WriteLine(this.status);
    }
}

/// <summary>
/// Represents the arguments for the HPCheck event, containing the current health value.
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// Gets the current health value.
    /// </summary>
    public float currentHP { get; }

    /// <summary>
    /// Initializes a new instance of the CurrentHPArgs class with the specified health value.
    /// </summary>
    public CurrentHPArgs(float newHp)
    {
        currentHP = newHp;
    }
}
