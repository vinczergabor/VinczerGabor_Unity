using UnityEngine;

class PlayerMover : MonoBehaviour
{
    // [SerializeField] Vector3 velocity;
    [SerializeField] float speed = 10;
    [SerializeField] float angularSpeed = 300;

    void Update()
    {
        // Transform t = transform;
        //t.position= velocity;

        // transform.position = transform.position + velocity;

        Vector3 direction = GetInputVector();

        if (direction != Vector3.zero)
        {
            //Vector3 velocity= Vector3.right * speed; <- a Vector3.right egy 1,0,0 értéket ad, ezt szorozzuk a speed értékével
            Vector3 velocity = direction * speed;    
            transform.position += velocity * Time.deltaTime; // a Time.deltaTime-al framerate függetlenné tettük (jelen esteben a mozgást)

            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.RotateTowards (transform.rotation, targetRotation, angularSpeed * Time.deltaTime);

            // transform.rotation = Quaternion.LookRotation(direction);  <- a mozgás irányába fordul az object
            // transform.rotation = Quaternion.LookRotation(direction, Vector3.up); megadhatjuk, hogy konkrétan melyik irányba nézzen
        }





    }

    Vector3 GetInputVector()
    {
        /*
        Ez ittt a standard input setupolás. A unity-ben van erre beépített is, de ez itt a standard kódolás.
        // --- Billentyûlementések elmentése
        bool inputUp = Input.GetKey(KeyCode.W);
        bool inputDown = Input.GetKey(KeyCode.S);
        bool inputLeft = Input.GetKey(KeyCode.A);
        bool inputRight = Input.GetKey(KeyCode.D);



        // --- X mozgás definiálása a billentyûlenyomáshoz

        float x = BoolsToDirection(inputRight, inputLeft);

        // --- Y mozgás definiálása a billentyûlenyomáshoz

        float z = BoolsToDirection(inputUp, inputDown);

        */

        // Ezekkel a Unity Project Settings/Input managerében lévõ beállításokra hivatkozunk azok neveivel (Az input managernek van újabb verziója, az Input Systems, amit Unity pakage-ként kell telepíteni)
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 direction = new(x, 0, z);

        direction.Normalize();
        return direction;
    }

    // --- mozgások általános definíciója, amikbõl dolgozunk feljebb
    float BoolsToDirection(bool positive, bool negative)
    {
        float result = 0;
        if (positive)
            result += 1;
        if (negative)
            result -= 1;
        return result;
    }
}
