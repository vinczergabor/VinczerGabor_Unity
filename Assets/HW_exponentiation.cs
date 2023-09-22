using UnityEngine;

public class HW_exponentiation : MonoBehaviour
{
    [SerializeField] int baseNumber, expontent, result;

    void OnValidate()
    {
        result = baseNumber;

        if (expontent == 0)
        {
            result = 0;
        }
        else
        {
            for (int i = 1; i < expontent; i++)
            {
                result = result * baseNumber;
            }

        }
        
    }
}
