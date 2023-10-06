using UnityEngine;

class MoverWithArrows : MonoBehaviour
{

    [SerializeField] float speed = 1;

    
    void Update()
    {
        // Get keyboard data
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // create direction vector that store the input data, then normalize it to get a direction vector
        Vector3 direction = new(x, 0, z);
        direction.Normalize();

        // move the object to the arow direction based on the speed
        if(direction != Vector3.zero)
        {
            Vector3 velocity = direction * speed;

            transform.position += velocity * Time.deltaTime;

            // This is the same:
            // transform.Translate(direction * (Time.deltaTime * speed));
        }


    }
}
