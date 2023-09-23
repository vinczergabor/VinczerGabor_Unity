using UnityEngine;

public class HW_exponentiation : MonoBehaviour
{
    [SerializeField] int expontent;
    [SerializeField] float baseNumber, result;

    void OnValidate()
    {
        result = 1;

        
            for (int i = 0; i < expontent; i++)
            {
                result = result * baseNumber;
                // result *= baseNumber;
            }

        
        
    }
}
