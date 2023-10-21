using UnityEngine;

class ClickComponentSwitch : MonoBehaviour
{
	[SerializeField] Behaviour component;

	void OnMouseDown()
	{
		component.enabled = !component.enabled; // negalas
	}
}
