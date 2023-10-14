using UnityEngine;

class TargetFollower : MonoBehaviour
{
    [SerializeField] Transform target;





	void Update()
	{
		float x = target.position.x;
		float y = target.position.y;
		float z = transform.position.z;

		Vector3 followVector = new(x, y, z);

		transform.position = followVector;

		

		
	}
}
