using UnityEngine;

class Align : MonoBehaviour
{
	[SerializeField] Transform[] elements;


	void Update()
	{
		Transform[] elements = new Transform[transform.childCount];
		for(int i = 0; i < elements.Length; i++)
			elements[i] = transform.GetChild(i);


		Vector3 startPoint = elements[0].position;
		Vector3 endPoint = elements[^1].position;

		Quaternion startRotation = elements[0].rotation;
		Quaternion endRotation = elements[^1].rotation;
		// Vector3 fullDistanceVector = endPoint - startPoint;
		// Vector3 smallDistanceVector =
		// fullDistanceVector / (elements.Length - 1);
		// Vector3 currentPoint = startPoint;

		for (int i = 1; i < elements.Length - 1; i++)
		{
			float t = (float)i / (elements.Length - 1);

			Vector3 p = Vector3.Lerp(startPoint, endPoint, t);
			Quaternion r = Quaternion.Lerp(startRotation, endRotation, t);
			elements[i].SetPositionAndRotation(p, r);
		}
	}

}
