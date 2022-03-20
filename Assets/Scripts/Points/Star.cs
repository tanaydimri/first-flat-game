using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    [SerializeField] private int scoreStrength = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player")
        { 
            return;
        }

        Destroy(gameObject);
        GameEventSystem.Instance.IncrementScore(scoreStrength);
    }
}
