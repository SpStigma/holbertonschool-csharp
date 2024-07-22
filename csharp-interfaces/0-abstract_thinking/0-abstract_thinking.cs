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
    /// Returns a string representation of the object in the format.
    /// </summary>
    public override string ToString()
    {
        return $"{name} is a {GetType().Name}";
    }
}
