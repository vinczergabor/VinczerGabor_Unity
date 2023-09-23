
using UnityEngine;

class MethodPractice : MonoBehaviour
{
    [SerializeField] float input;
    [SerializeField] float abs;
   
    void OnValidate()
    {
       /*
        float pow = Mathf.Pow(2, 3);    // 8
        float abs = Mathf.Abs(-12);     // 12
        float sign = Mathf.Sign(-34);   // -1
        float rounded = Mathf.Round(22.75f); //23f kerekít
        float floored = Mathf.Floor(22.999f); // 22f lefelé kerekít
        float ceiled = Mathf.Ceil(22.03f); // 23f felfelé kerekít

        float min = Mathf.Min(12, 4);       // 4
        float max = Mathf.Max(12, 4);       // 47
        */
        abs = MyAbs(input);

    }

    float MyAbs(float number)
    {
        if (number < 0)
            return -number;
        else
            return number;
    }
    
}
