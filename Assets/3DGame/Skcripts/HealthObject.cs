using System;
using System.Collections;
using UnityEngine;

class HealthObject : MonoBehaviour
{
    [SerializeField] int startHealth = 10;

	[SerializeField] float invincibilityFrames = 2f;
	[SerializeField] float flickTime = 0.2f;

    int currentHealth;

    private void Start()
    {
        currentHealth = startHealth;
    }
    public void Damage(int damage)
    {
        if (currentHealth <= 0) return;

        currentHealth -= damage;
		StartCoroutine(StartInvincibility());

        if(currentHealth < 0)
        {
            currentHealth = 0;
        }

        if (currentHealth <= 0)
            Debug.Log("I'm Dead");
    }

	IEnumerator StartInvincibility()
	{
		Collider coll = GetComponentInChildren<Collider>();
		Renderer[] renderers = GetComponentsInChildren<Renderer>();
		coll.enabled = false;

		float maxTime = Time.time + invincibilityFrames;
		while (Time.time < maxTime)
		{
			yield return new WaitForSeconds(flickTime);
			foreach (Renderer renderer in renderers)
				renderer.enabled = !renderer.enabled;
		}

		foreach (Renderer renderer in renderers)
			renderer.enabled = true;

		coll.enabled = true;
	}

	void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            currentHealth = startHealth;
        }
    }
}
