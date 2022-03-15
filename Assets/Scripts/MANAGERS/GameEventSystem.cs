using UnityEngine;
using System;

public class GameEventSystem : MonoBehaviour
{
    public static GameEventSystem current;

    private void Awake()
    {
        current = this;
    }
    
    public event Action onStarCollected;
    public void StarCollected()
    {
        if (onStarCollected != null)
        {
            onStarCollected();
        }
    }

    public event Action<int> onScoreUpdated;
    public void ScoreUpdated(int currentScore)
    {
        if (onScoreUpdated != null)
        {
            onScoreUpdated(currentScore);
        }
    }
}
