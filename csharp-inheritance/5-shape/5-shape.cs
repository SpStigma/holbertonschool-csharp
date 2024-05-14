using System;

/// <summary>
/// Represent The Shape class.
/// </summary>
class Shape
{
    /// <summary>
    /// Method taht throw an exeption.
    /// </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
