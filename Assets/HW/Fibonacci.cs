using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fibonacci : MonoBehaviour
{
    int[] FibonacciMaker(int length)
    {
        int[] result = new int[length];

        if (length > 0)
            result[0] = 0;

        if (length > 1)
            result[1] = 1;

        for (int i = 2; i < length; i++)
            result[i] = result[i - 1] + result[i - 2];

        return result;
    }
}
