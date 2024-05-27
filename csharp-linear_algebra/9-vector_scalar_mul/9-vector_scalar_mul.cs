using System;

/// <summary>
/// Represent the VectorMath.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Method that Vector-scalar multiplication.
    /// </summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length != 2 && vector.Length != 3)
        {
            return new double[] {-1};
        }

        double[] newVector = new double[vector.Length];

        for (int i = 0; i < vector.Length; i++)
        {
            newVector[i] = vector[i] * scalar;
        }

        return newVector;
    }
}