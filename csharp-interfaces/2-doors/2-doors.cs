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