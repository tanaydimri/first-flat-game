using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Debug.Log("Shooting Now");

        // If the player is crouching, the bullet should start from a lower point on Y
        bool _isPlayerCrouching = animator.GetBool("IsCrouching");
        Vector3 processedTransform = firePoint.position;

        if (_isPlayerCrouching)
        {
            processedTransform.y -= 0.08f;
        }

        Instantiate(bulletPrefab, processedTransform, firePoint.rotation);
    }
}
