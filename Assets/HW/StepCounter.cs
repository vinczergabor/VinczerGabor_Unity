using UnityEngine;

class StepCounter : MonoBehaviour
{

    [SerializeField] Vector2 a, b;
    [SerializeField] int numberOfJumps;
    [SerializeField] float distance;
    [SerializeField] Vector2 jumpSize;

    float JumpDistance (Vector2 x, Vector2 y)
    {
        Vector2 direction = y - x;

        return direction.magnitude;
    }

    int JumpNumber (Vector2 x, Vector2 y)
    {
        
        int jumpCount = Mathf.CeilToInt(JumpDistance(x, y) / 1f);

        return jumpCount;

    }

    Vector2 SizeOfJump(Vector2 x, Vector2 y)
    {
        Vector2 vectorDir = y - x;

        return vectorDir / JumpNumber(x, y);
    }
    
    void OnValidate()
    {
        distance = JumpDistance(a, b);
        numberOfJumps = JumpNumber(a, b);
        jumpSize = SizeOfJump(a, b);
    }
}
