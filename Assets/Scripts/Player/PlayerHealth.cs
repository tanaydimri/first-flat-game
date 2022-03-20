using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int playerHealth = 100;
    public Transform playerDeathEffect;

    // Singleton reference to this class instance
    public static PlayerHealth current { get; private set; }

    private void Awake()
    {
        if (current != null && current != this)
        {
            Destroy(current);
        }
        else 
        {
            current = this;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Might move this method to a different script in the future, or maybe a part of the PlayerMovement.cs itself.
        if (collision.tag == "Enemy")
        {
            EnemyGeneric hitEnemy = collision.GetComponent<EnemyGeneric>();
            TakeDamage(hitEnemy.playerDamageFactor);
        }
    }

    private void TakeDamage(int damageFactor)
    {
        playerHealth -= damageFactor;

        if (playerHealth > 0)
        {
            playerHealth -= damageFactor;
        }

        if (playerHealth < 0)
        {
            playerHealth = 0;
        }

        if (playerHealth == 0)
        {
            Instantiate(playerDeathEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        GameEventSystem.Instance.PlayerHealthUpdated();
    }
}
