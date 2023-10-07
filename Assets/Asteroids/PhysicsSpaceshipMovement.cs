using UnityEngine;

// nem engedi leveni a komponenst, ill. automatikusan rapakolja a script rapakolasakor
[RequireComponent(typeof(Rigidbody2D))]

public class PhysicsSpaceshipMovement : MonoBehaviour
{
    [SerializeField] float angularSpeed = 180f;
    [SerializeField] float maxSpeed = 2f;
    [SerializeField] float acceleration = 1;

	[SerializeField,HideInInspector] Rigidbody2D rigidBody2D;

	void OnValidate()
	{
		rigidBody2D= GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()
    {
		// Acceleration
		float movementInput = Input.GetAxisRaw("Vertical");

		if (movementInput > 0)
		{
			
			Vector2 globalDirection = transform.up * movementInput;
			rigidBody2D.velocity += acceleration * Time.fixedDeltaTime * globalDirection;

			// itt az erot adjuk hozza a mozgashoz. Ha nehezebbre van allitva a tomeg, lassabban gyorsul a targy
			// rigidBody2D.AddForce(acceleration * globalDirection);
			 


			// maximalom a sebesseget:
			rigidBody2D.velocity = Vector2.ClampMagnitude(rigidBody2D.velocity, maxSpeed);

			
		}
	}
	void Update()
	{
		// Rotation
		float rotationInput = -Input.GetAxisRaw("Horizontal");
		transform.Rotate(0, 0, rotationInput * angularSpeed * Time.deltaTime);
		// kinullazom a rigid body tehetetlensegi forgasat
		rigidBody2D.angularVelocity = 0;

	}
}
