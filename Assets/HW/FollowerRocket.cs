using UnityEngine;

public class FollowerRocket : MonoBehaviour
{
	[SerializeField] Transform target;
	[SerializeField] float speed = 5;
	[SerializeField] float angularSpeed = 180;

	private void Update()
	{
		Transform self = transform;

		Vector3 tagetDirection = target.position - self.position;
		Quaternion targetRotation = Quaternion.LookRotation(tagetDirection);

		float maxAngle = angularSpeed * Time.deltaTime;
		self.rotation = Quaternion.RotateTowards(self.rotation, targetRotation, maxAngle);

		// float offset = speed * Time.deltaTime;
		self.position += speed * Time.deltaTime * self.forward;
	}
}
