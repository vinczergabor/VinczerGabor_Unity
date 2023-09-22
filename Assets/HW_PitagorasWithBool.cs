using UnityEngine;

public class HW_PitagorasWithBool : MonoBehaviour
{
    [SerializeField] float a, b, c;
    [SerializeField] string isItRightAngle ="No";

    bool PitagorasChecker(float sideA, float sideB, float sideC)
    {
        
        bool isPitagoras = sideA * sideA + sideB * sideB == sideC * sideC;

        return isPitagoras;
    }

    void WriteResult()
    {
        if (PitagorasChecker(a, b, c))
            isItRightAngle = "Yes";

        else
            isItRightAngle = "No";
    }

    void OnValidate()
    {
        WriteResult();
    }
}
