using UnityEngine;

public class HW_Pitagoras : MonoBehaviour
{
    
    [SerializeField] float a, b, c;
    [Space] // Az inspectorban kihagy egy kis helyet
    [Header("The Result")] // El lehet nevezni r�szeket �gy
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
