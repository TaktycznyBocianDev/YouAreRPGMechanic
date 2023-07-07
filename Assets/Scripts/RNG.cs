using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RNG 
{

    public enum Dices
    {
        SixSides,
        TenSides,
        OneHSides
    }


    static int RNGenerator(int x)
    {
        if (x < 0)
        {
            x = -x;
        }

        return Random.Range(0, x + 1);
    }

    static int RNGenerator(int min, int max)
    {
        if (min < 0)
        {
            min = -min;
        }
        if (max < 0)
        {
            max = -max;
        }

        return Random.Range(min, max + 1);
    }

    static int DicesGenerator(Dices dice, int howMany)
    {
        int sum = 0;

        if (dice == Dices.SixSides)
        {
            for (int i = 0; i < howMany; i++)
            {
                sum += RNGenerator(6);
            }
            return sum;
        }
        else if (dice == Dices.TenSides)
        {
            for (int i = 0; i < howMany; i++)
            {
                sum += RNGenerator(10);
            }
            return sum;
        }
        else if (dice == Dices.OneHSides)
        {
            for (int i = 0; i < howMany; i++)
            {
                sum += RNGenerator(100);
            }
            return sum;
        }
        else return 0;
    }
}
