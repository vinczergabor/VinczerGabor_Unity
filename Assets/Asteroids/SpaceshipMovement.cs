using UnityEngine;

class SpaceshipMovement : MonoBehaviour
{
    [SerializeField] float angularSpeed = 180f;
    [SerializeField] float maxSpeed = 2f;
    [SerializeField] float acceleration = 1;
    [SerializeField] float drag = 0.2f;

    Vector3 velocity;

    void FixedUpdate()
    {
        
        

        // Acceleration
        float movementInput = Input.GetAxisRaw("Vertical");

        if (movementInput > 0)
        {
            // Alternativak:
            // movementInput = Mathf.Clamp(movementInput, -1, 1);
            // movementInput = Mathf.Clamp01(movementInput);

            // Vector3 direction= new Vector3(0, movementInput, 0);
            // Vector3 globalDirection = transform.TransformDirection(direction);

            Vector3 globalDirection = transform.up * movementInput;
            velocity += acceleration * Time.fixedDeltaTime * globalDirection;
            // maximalom a sebesseget:
            velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
        }

        // Kozegellenalas
        Vector3 dragAcceleration = -velocity * drag;
        velocity += dragAcceleration * Time.fixedDeltaTime;

        
    }

    void Update()
    {
        // Rotation
        float rotationInput = -Input.GetAxisRaw("Horizontal");
        transform.Rotate(0, 0, rotationInput * angularSpeed * Time.deltaTime);

        // Movement
        transform.position += velocity * Time.deltaTime;
    }

}
