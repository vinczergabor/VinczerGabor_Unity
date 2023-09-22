using UnityEngine;

class HW_minMax : MonoBehaviour
{
    [SerializeField] float firstNumber, secondNumber, minValue, maxValue;

    float MyMin(float a, float b)
    {
        float minResult;

        if (a < b)
            minResult = a;
        else
            minResult = b;

        return minResult;
    }

    float MyMax (float c, float d)
    {
        float maxResult;

        if (c > d)
            maxResult = c;
        else
            maxResult = d;

        return maxResult;
    }

    void OnValidate()
    {
        minValue = MyMin(firstNumber, secondNumber);
        maxValue = MyMax(firstNumber, secondNumber);
    }
}
