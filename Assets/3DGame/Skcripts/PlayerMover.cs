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
            //Vector3 velocity= Vector3.right * speed; <- a Vector3.right egy 1,0,0 �rt�ket ad, ezt szorozzuk a speed �rt�k�vel
            Vector3 velocity = direction * speed;    
            transform.position += velocity * Time.deltaTime; // a Time.deltaTime-al framerate f�ggetlenn� tett�k (jelen esteben a mozg�st)

            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.RotateTowards (transform.rotation, targetRotation, angularSpeed * Time.deltaTime);

            // transform.rotation = Quaternion.LookRotation(direction);  <- a mozg�s ir�ny�ba fordul az object
            // transform.rotation = Quaternion.LookRotation(direction, Vector3.up); megadhatjuk, hogy konkr�tan melyik ir�nyba n�zzen
        }





    }

    Vector3 GetInputVector()
    {
        /*
        Ez ittt a standard input setupol�s. A unity-ben van erre be�p�tett is, de ez itt a standard k�dol�s.
        // --- Billenty�lement�sek elment�se
        bool inputUp = Input.GetKey(KeyCode.W);
        bool inputDown = Input.GetKey(KeyCode.S);
        bool inputLeft = Input.GetKey(KeyCode.A);
        bool inputRight = Input.GetKey(KeyCode.D);



        // --- X mozg�s defini�l�sa a billenty�lenyom�shoz

        float x = BoolsToDirection(inputRight, inputLeft);

        // --- Y mozg�s defini�l�sa a billenty�lenyom�shoz

        float z = BoolsToDirection(inputUp, inputDown);

        */

        // Ezekkel a Unity Project Settings/Input manager�ben l�v� be�ll�t�sokra hivatkozunk azok neveivel (Az input managernek van �jabb verzi�ja, az Input Systems, amit Unity pakage-k�nt kell telep�teni)
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 direction = new(x, 0, z);

        direction.Normalize();
        return direction;
    }

    // --- mozg�sok �ltal�nos defin�ci�ja, amikb�l dolgozunk feljebb
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
