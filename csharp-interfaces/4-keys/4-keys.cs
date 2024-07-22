using System;

/// <summary>
/// Represents an abstract base class that provides a common name property and a custom string representation.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Gets or sets the name of the object.
    /// </summary>
    public string name { get; set; }
    
    /// <summary>
    /// Returns a string representation of the object in the format "{name} is a {TypeName}".
    /// </summary>
    /// <returns>
    /// A string representation of the object.
    /// </returns>
    public override string ToString()
    {
        return $"{name} is a {GetType().Name}";
    }
}

/// <summary>
/// Defines an interface for interactive objects that can perform some action when interacted with.
/// </summary>
interface IInteractive
{
    /// <summary>
    /// Defines an action that occurs when the object is interacted with.
    /// </summary>
    void Interact();
}

/// <summary>
/// Defines an interface for breakable objects with a durability property and a break action.
/// </summary>
interface IBreakable
{
    /// <summary>
    /// Gets or sets the durability of the object, indicating how much damage it can take before breaking.
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Defines an action that occurs when the object breaks.
    /// </summary>
    void Break();
}

/// <summary>
/// Defines an interface for collectable objects with a collection status and a collect action.
/// </summary>
interface ICollectable
{
    /// <summary>
    /// Gets or sets a value indicating whether the object has been collected.
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Defines an action that occurs when the object is collected.
    /// </summary>
    void Collect();
}

/// <summary>
/// Represent the Door class that inherit from Base and IInteractive
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Represent Constructor that set Name to Door by default.
    /// </summary>
    public Door(string Name = "Door")
    {
        name = Name;
    }

    /// <summary>
    /// Represent a mathod Interact from IInteractive.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

/// <summary>
/// Represents a decoration that can be interacted with and is breakable.
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// Gets or sets a value indicating whether the decoration is a quest item.
    /// </summary>
    public bool isQuestItem { get; set; }
    
    /// <summary>
    /// Gets or sets the durability of the decoration, indicating how much damage it can take before breaking.
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Initializes a new instance of the Decoration class with specified values.
    /// </summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new ArgumentException("Durability must be greater than 0");
        }

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Defines what happens when the decoration is interacted with.
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    /// <summary>
    /// Defines the action that occurs when the decoration breaks.
    /// </summary>
    public void Break()
    {
        if (durability > 0)
        {
            durability--;
            if (durability > 0)
            {
                Console.WriteLine($"You hit the {name}. It cracks.");
            }
            else if (durability == 0)
            {
                Console.WriteLine($"You smash the {name}. What a mess.");
            }
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}

/// <summary>
/// Represents a key that can be collected.
/// </summary>
public class Key : Base, ICollectable
{
    /// <summary>
    /// Gets or sets a value indicating whether the key has been collected.
    /// </summary>
    public bool isCollected { get; set; }
    
    /// <summary>
    /// Initializes a new instance of the class with the specified name and collection status.
    /// </summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Defines the action that occurs when the key is collected.
    /// </summary>
    public void Collect()
    {
        if(isCollected == false)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}
