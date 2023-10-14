using UnityEngine;

class JoeMover : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float jumpDistance = 5f;

    [SerializeField] GameObject sameGameObject;

    float x;
    


	private void FixedUpdate()
	{
		Vector3 jumpTarget = GetJumpVector();

		if (jumpTarget != Vector3.zero)
		// if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			// rigidBody2D.velocity = jumpDistance * Time.deltaTime * jumpTarget;

			Vector3 jumpUp = transform.position + GetJumpVector();
			transform.position = Vector3.MoveTowards(transform.position, jumpUp, jumpDistance * Time.fixedDeltaTime);

			// transform.position += jumpDistance * Time.deltaTime * jumpTarget;
		}
	}

	void Update()
	{
        Vector3 target = GetInputVector();

        

		if (target != Vector3.zero)
        {

            transform.position += speed * Time.deltaTime * target;
			SetDirection(x);
            
        }

	}

	Vector3 GetInputVector()
    {
        x = Input.GetAxis("Horizontal");

        

		Vector3 inputVector = new(x, 0, 0);
        inputVector.Normalize();

        return inputVector;
    }

    Vector3 GetJumpVector()
    {
        float y = Input.GetAxisRaw("Vertical");
        

        Vector3 jumpVector = new(0, y, 0);
        jumpVector.Normalize();
                
        return jumpVector;
    }

	void SetDirection(float direction)
	{
		SpriteRenderer flip = sameGameObject.GetComponent<SpriteRenderer>();

		if (direction < 0)
		{
			flip.flipX = true;
		}
		else
		{
			flip.flipX = false;
		}

	}
}
