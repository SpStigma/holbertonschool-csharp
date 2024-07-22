using System;


/// <summary>
/// Represent a bastract class Base.
/// </summary>
public abstract class Base
{
    public string name { get; set; }
    
    /// <summary>
    /// Returns a string representation of the object in the format "<name> is a <type>".
    /// </summary>
    public override string ToString()
    {
        return $"{name} is a {GetType().Name}";
    }
    
}
