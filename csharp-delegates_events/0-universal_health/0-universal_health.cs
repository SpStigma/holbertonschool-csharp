using System;

/// <summary>
/// Represent the Player class with 3 differents properties.
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// Constructor to initialize the properties name and maxHp and hp
    /// </summary>
    public Player(string name ="Player", float maxHp = 100)
    {
        this.name = name;

        if (maxHp < 0)
        {
            this.maxHp = 100;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }
        this.hp = maxHp;
    }

    /// <summary>
    /// Method to Print Health.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
}
