using UnityEngine;
class PracticeCalculator : MonoBehaviour
{
	[SerializeField] float a, b;
    [SerializeField] float amount, difference, product, division;

    void Amount(float a, float b)
    {
        amount = a + b;

    }

    void Difference(float a, float b)
    {
        difference = a - b;
    }

    void Product(float a, float b)
    {
        product = a * b;
    }

    void Divide(float a, float b)
    {
        division = a / b;
    }

    void OnValidate()
    {
        Amount(a, b);
        Difference(a, b);
        Product(a, b);
        Divide(a, b);
    }
}

