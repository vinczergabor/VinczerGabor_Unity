using UnityEngine;

public class Collector : MonoBehaviour
{
	int collectedValue = 0;
	private void OnTriggerEnter(Collider other)
	{
		if(other.TryGetComponent<Collectable>(out Collectable collectable))
		{
			collectedValue += collectable.GetValue();
			collectable.Teleport();
		}
	}
}
