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
/// Represents a test object that inherits from the base class and implements all the provided interfaces.
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// Implements the Interact method from IInteractive interface.
    /// </summary>
    public void Interact()
    {

    }

    /// <summary>
    /// Implements the Durability property from IBreakable interface.
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Implements the Break method from IBreakable interface.
    /// </summary>
    public void Break()
    {

    }

    /// <summary>
    /// Implements the IsCollected property from ICollectable interface.
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Implements the Collect method from ICollectable interface.
    /// </summary>
    public void Collect()
    {

    }
}
