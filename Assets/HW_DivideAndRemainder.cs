using UnityEngine;

class HW_DivideAndRemainder : MonoBehaviour
{
    [SerializeField] int number = 1;
    [SerializeField] int divider = 1;
    [SerializeField] int result;
    [SerializeField] int remainder;


    void OnValidate()
    {
        result = number / divider;
        remainder = number % divider;

        
    }
}
