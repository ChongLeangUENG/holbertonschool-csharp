﻿using System;

/// <summary>
/// Public class
/// </summary>
public static class VectorMath 
{
    /// <summary>
    /// Public static
    /// </summary>
    /// <param name="vector"></param>
    /// <returns></returns>
    public static double Magnitude(double[] vector) 
    {
        if (vector == null) 
        {
            return -1;
        }

        double sum = 0.0;

        if (vector.Length == 2 || vector.Length == 3) 
        {
            foreach (double component in vector) 
            {
                sum += component * component;
            }
            return Math.Round(Math.Sqrt(sum), 2); // rounding to the nearest hundredth
        } 
        else 
        {
            return -1;
        }
    }
}
