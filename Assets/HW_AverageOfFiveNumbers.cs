
using UnityEngine;

class HW_AverageOfFiveNumbers : MonoBehaviour
{

    [SerializeField] int number1, number2, number3, number4, number5;
    [SerializeField] float average;
    
    void OnValidate()
    {
        average = (number1 + number2 + number3 + number4 + number5) / 5f;
    }
}
