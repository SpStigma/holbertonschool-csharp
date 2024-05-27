using System;

/// <summary>
/// Represent the Vector class.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Method to calculate the Magnitude of a vector.
    /// </summary>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length != 2 && vector.Length != 3)
        {
            return -1;
        }

        double result = 0;

        foreach (double coordinate in vector)
        {
            result += coordinate * coordinate;
        }

        return Math.Round(Math.Sqrt(result), 2);
    }
}