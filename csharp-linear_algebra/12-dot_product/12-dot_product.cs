using System;

/// <summary>
/// Represent VectorMath class.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Method to return Dot product of either 2D or 3D vectors.
    /// </summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if ((vector1.Length != 2 && vector1.Length != 3) || (vector2.Length != 2 && vector2.Length != 3))
        {
            return -1;
        }

        if (vector1.Length != vector2.Length)
        {
            return -1;
        }

        double dotProduct = 0;

        for (int i = 0; i < vector1.Length; i++)
        {
            dotProduct += vector1[i] * vector2[i];
        } 
        return dotProduct;
    }
}

