using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int currentScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        GameEventSystem.current.onStarCollected += OnStarCollected;
    }

    private void OnStarCollected()
    {
        currentScore += 1;
        GameEventSystem.current.ScoreUpdated(currentScore);
    }
}
