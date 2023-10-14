using UnityEngine;

class BackgoundBehaviour : MonoBehaviour
{
    [SerializeField] Transform target;

    void Update()
    {
		float x = target.position.x;
		float y = transform.position.y;
		float z = transform.position.z;

		Vector3 followVector = new(x, y, z);

		transform.position = followVector;
	}
}
