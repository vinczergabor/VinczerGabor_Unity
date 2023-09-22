using UnityEngine;

public class HW_Pitagoras : MonoBehaviour
{
    [SerializeField] float a, b, c;
    [SerializeField] string isItRightAngle ="No";

    void OnValidate()
    {
        if (a*a + b*b == c*c)
            isItRightAngle = "Yes";
        
        else
             isItRightAngle = "No";

        // isItRightAngle = (a * a + b * b == c * c) ? "Yes" : "No";


    }
}
