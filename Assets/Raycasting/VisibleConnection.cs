using UnityEngine;

[ExecuteAlways]  // a script igy mindig lefut az editorban nem kell hozza a play mod
class VisibleConnection : MonoBehaviour
{
	[SerializeField] Transform other;
	[SerializeField] LineRenderer line;

	void Update()
	{
		Vector3 p1 = transform.position;
		Vector3 p2 = other.position;

		Vector3[] points = { p1, p2 };
		line.SetPositions(points);
		line.positionCount = 2;
	}

}