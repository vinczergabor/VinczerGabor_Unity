using UnityEngine;

class IsItPrime : MonoBehaviour
{
    [SerializeField] int number = 1;
    [SerializeField] bool isItPrime = true;
    [SerializeField] int sumOfNumbers = 0;

    bool PrimeDecider(int number)
    {
        if (number != 1)
        {
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                    return false;
                else
                    return true;
            }
        }
        
        return true;
    }

    int SumOfNumbers(int value)
    {
        int sum = 0;

        while ( value != 0)
        {
            int number = value % 10;
            sum += number;
            value /= 10;
        }

        return sum;

    }

    void OnValidate()
    {
        isItPrime = PrimeDecider(number);
        sumOfNumbers = SumOfNumbers(number);
    }
}
