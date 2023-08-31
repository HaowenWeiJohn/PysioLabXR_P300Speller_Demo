using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GeneralUtils
{
    public static int FindLargestValueIndex(float[] array)
    {
        float largestValue = float.MinValue;
        int largestIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > largestValue)
            {
                largestValue = array[i];
                largestIndex = i;
            }
        }

        return largestIndex;
    }

    public static int FindLargestValueIndex(int[] array)
    {
        int largestValue = int.MinValue;
        int largestIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > largestValue)
            {
                largestValue = array[i];
                largestIndex = i;
            }
        }

        return largestIndex;
    }


    public static int FindLargestValueIndex(double[] array)
    {
        double largestValue = double.MinValue;
        int largestIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > largestValue)
            {
                largestValue = array[i];
                largestIndex = i;
            }
        }

        return largestIndex;
    }

}