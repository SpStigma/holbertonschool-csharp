using System;

/// <summary>
/// Represents the Player class with 3 different properties.
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// Delegate to calculate health modifications.
    /// </summary>
    public delegate void CalculateHealth(float amount);

    /// <summary>
    /// Constructor to initialize the properties name and maxHp and hp
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
    }

    /// <summary>
    /// Method to print health.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    /// <summary>
    /// Method to apply damage to the player.
    /// </summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
        }
        Console.WriteLine($"{this.name} takes {damage} damage!");
        this.hp = this.hp - damage;
    }

    /// <summary>
    /// Method to heal the player.
    /// </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }
        Console.WriteLine($"{this.name} heals {heal} HP!");
        this.hp = this.hp + heal;
    }

}
