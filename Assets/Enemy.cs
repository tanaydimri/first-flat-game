using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public Transform explosionEffect;

    public void TakeDamage(int damageAmount) {
        health -= damageAmount;

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die() {
        Instantiate(explosionEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
