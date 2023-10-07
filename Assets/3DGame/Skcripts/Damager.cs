using UnityEngine;

class Damager : MonoBehaviour
{
    [SerializeField] int damage = 5;
    void OnTriggerEnter(Collider other)
    {
        GameObject otherGameObject = other.gameObject;

        HealthObject healthObject= other.GetComponent<HealthObject>();

        if (healthObject != null)
        {
            // Debug.Log(other.gameObject.name);
            healthObject.Damage(damage);
        }

        
    }
}
