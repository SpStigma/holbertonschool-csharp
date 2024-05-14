using System;

/// <summary>
/// Represents the Shape class.
/// </summary>
class Shape
{
    /// <summary>
    /// Method that throws an exception.
    /// </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Represent the Rectangle class that inherit from Shape
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }

    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }

    /// <summary>
    /// Method to return the Area of a Rectangle that override the Shape Method.
    /// </summary>
    public override int Area()
    {
        return width * height;
    }

    /// <summary>
    /// Metod to return a specifieds string that overrride the shape method.
    /// </summary>
    public override string ToString()
    {
        return $"[Rectangle] {Width} / {Height}";
    }
}
