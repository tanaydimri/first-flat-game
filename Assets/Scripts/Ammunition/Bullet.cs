using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 50;
    public Transform bulletImpactEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool playImpactEffect = false;

        EnemyGeneric hitEnemy = collision.GetComponent<EnemyGeneric>();
        if (hitEnemy != null)
        {
            hitEnemy.TakeDamage(damage);
            Destroy(gameObject);
            playImpactEffect = true;
        }

        if (collision.tag == "GroundCollider")
        {
            Destroy(gameObject);
            playImpactEffect = true;
        }

        if (playImpactEffect)
        {
            Transform bulletImpact = Instantiate(bulletImpactEffect, transform.position, transform.rotation);
            Destroy(bulletImpact.gameObject, 1f);
        }
    }
}
