﻿using System;

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
        if (vector1.Length != 3 || vector2.Length != 3)
        {
            return new double[] {-1};
        }

        double[] crossProduct = new double[3];

        crossProduct[0] = Math.Round((vector1[1] * vector2[2]) - (vector1[2] * vector2[1]), 2);
        crossProduct[1] = Math.Round((vector1[2] * vector2[0]) - (vector1[0] * vector2[2]), 2);
        crossProduct[2] = Math.Round((vector1[0] * vector2[1]) - (vector1[1] * vector2[0]), 2);

        return crossProduct;
    }
}

