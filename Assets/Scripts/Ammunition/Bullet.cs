using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 50;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        EnemyGeneric hitEnemy = collision.GetComponent<EnemyGeneric>();
        if (hitEnemy != null)
        {
            hitEnemy.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
