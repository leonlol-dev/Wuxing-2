using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float health = 50f;

    private void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }
    public void TakeDamage (float amount)
    {
        health -= amount;
        
        
    }

    void Die()
    {
        Destroy(gameObject);

    }
}
