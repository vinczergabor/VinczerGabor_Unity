using UnityEngine;

class VectorPractice : MonoBehaviour
{
    void Start()
    {
        Vector2 v2_a = new Vector2(); // (0,0)
        Vector3 v3_a = new Vector3(); // (0,0,0)
        Vector2 v2_b = new Vector2(1, 2); // (1,2)
        Vector3 v3_b = new Vector3(3, 4, 5); // (3,4,5)

        Vector2 v2_c = new Vector2();
        Vector2 v2_d = new();
        var v2_e = new Vector2();

        Vector2 v2_f = v2_a + v2_b;  // (1,2)
        Vector2 v2_g = v2_a - v2_b;  // (-1,-2)
        Vector2 v2_h = v2_a * v2_b; // (3,6)
        Vector2 v2_i = v2_a / v2_b; // (0,5f, 1)

        float length = v2_f.magnitude;  // vektor hossza
        float length2 = v2_f.sqrMagnitude; // vektor négyzethossza


        Vector2 v2_j = v2_i.normalized; // vektor normalizáltját adja vssza az új változóba
        v2_i.Normalize(); // magát a vektor normalizálja


    }
    
}
