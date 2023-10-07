using System;
using UnityEngine;

class HealthObject : MonoBehaviour
{
    [SerializeField] int startHealth = 10;

    public int currentHealth;

    private void Start()
    {
        currentHealth = startHealth;
    }
    public void Damage(int damage)
    {
        if (currentHealth <= 0) return;

        currentHealth -= damage;

        if(currentHealth < 0)
        {
            currentHealth = 0;
        }

        if (currentHealth <= 0)
            Debug.Log("I'm Dead");
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            currentHealth = startHealth;
        }
    }
}
