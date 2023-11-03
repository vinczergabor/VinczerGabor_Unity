using UnityEngine;

public class Stomp : MonoBehaviour
{
    [SerializeField] float force = 10f;
    [SerializeField] float range = 5f;

	private void Update()
	{
		if (!Input.GetMouseButtonDown(0))
			return;

		Camera mainCam = Camera.main;
		Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);

		if (Physics.Raycast(ray, out RaycastHit hit) == false)
			return;

		Rigidbody[] rigidBodies = FindObjectsOfType<Rigidbody>();

		foreach(Rigidbody i in rigidBodies)
		{
			float distance = Vector3.Distance(i.transform.position, hit.point);
			float rate = 1 - (distance / range);

			if (rate > 0)
				i.AddForce(Vector3.up * (force * rate), ForceMode.Impulse);
		}

	}
}
