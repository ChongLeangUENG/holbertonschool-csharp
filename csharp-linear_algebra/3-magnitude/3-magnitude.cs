﻿using System;

public static class VectorMath 
{
    /// <summary>
    /// static double Magnitude
    /// </summary>
    /// <param name="vector"></param>
    /// <returns>rounded to the nearest hundredth</returns>
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
