using UnityEngine;

class Gun : MonoBehaviour
{
    [SerializeField] float radius;

    [SerializeField] float circumference;
    [SerializeField] float area;

    [SerializeField] int ammo = 10;
    [SerializeField] int magazineSize = 10;
    [SerializeField] int magazineCount = 5;


    void OnValidate()
    {
        // This is a commment
        /* This is a muléti-line comment */
        /*
        Debug.Log("Hello Unity!");
        Debug.Log($"Hello {name}!"); // The $ signs that a variable is being called between {} marks

        int myFirstvariable = 12;
        */
        // a % b = maradéka az osztásnak (modulo)
        // int j = (float) a -> a zárójelezés a kasztolás, átalakítjuk a változót

        

        // float pi = 3.14f;

        circumference = 2 * radius * Mathf.PI;

        area = radius * radius * Mathf.PI;  // gyorsabb
        area = Mathf.Pow(radius, 2) * Mathf.PI; // általánosabb
    }

     void Update()
    {
        
        bool shoot = Input.GetKeyDown(KeyCode.Space);

        if (shoot)
        {
            if ( ammo > 0)
            {
                Debug.Log("BUMMM");
                ammo--;
            }
            else
            {
                Debug.Log("CLICK!!");

                if(magazineCount > 0)
                {
                    magazineCount--;
                    ammo = magazineSize;
                }
            }
        }
        
    }

}
