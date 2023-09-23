using UnityEngine;

class HW_minMax : MonoBehaviour
{
    [SerializeField] float firstNumber, secondNumber, minValue, maxValue;

    float MyMin(float a, float b)
    {
        return a < b ? a : b;
    }

    float MyMax (float c, float d)
    {
        return c > d ? c : d;
        
    }

    void OnValidate()
    {
        minValue = MyMin(firstNumber, secondNumber);
        maxValue = MyMax(firstNumber, secondNumber);
    }
}
