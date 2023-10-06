using UnityEngine;

class VectorTester : MonoBehaviour
{
    [SerializeField] Vector3 vectorA, vectorB;
    [SerializeField] Vector3 result;

    Vector3 FromAtoB (Vector3 a, Vector3 b)
    {
        Vector3 r = b - a;

        return r.normalized;
    }

    
    void OnValidate()
    {
        result = FromAtoB(vectorA, vectorB);
    }
}
