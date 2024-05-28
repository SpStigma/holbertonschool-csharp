using System;

/// <summary>
/// Represent the VectorMath class.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Method to calculate a cross product between 2 vector 3D.
    /// </summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length || vector1.Length != 2 || vector2.Length != 2)
        {
            return new double[] {-1};
        }

        double[] crossProduct = new double[vector1.Length];

        crossProduct[0] = vector1[1] * vector2[2] - vector1[2] * vector2[1];
        crossProduct[1] = vector1[2] * vector2[0] - vector1[0] * vector2[2];
        crossProduct[2] = vector1[0] * vector2[1] - vector1[1] * vector2[0];

        return crossProduct;
    }
}

