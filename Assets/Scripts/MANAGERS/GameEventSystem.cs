using UnityEngine;
using System;

public class GameEventSystem : MonoBehaviour
{
    // Singleton reference to this class instance
    public static GameEventSystem Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(Instance);
        }
        else
        {
            Instance = this;
        }
    }
    
    public event Action<int> onIncrementScore;
    public void IncrementScore(int incrementFactor)
    {
        if (onIncrementScore != null)
        {
            onIncrementScore(incrementFactor);
        }
    }

    public event Action<int> onDecrementScore;
    public void DecrementScore(int decrementFactor)
    {
        if (onDecrementScore != null) 
        { 
            onDecrementScore(decrementFactor); 
        }
    }

    // Event to be called whenever the score in the game has been updated.
    public event Action<int> onScoreUpdated;
    public void ScoreUpdated(int currentScore)
    {
        if (onScoreUpdated != null)
        {
            onScoreUpdated(currentScore);
        }
    }

    public event Action onPlayerHealthUpdated;
    public void PlayerHealthUpdated()
    {
        if (onPlayerHealthUpdated != null)
        {
            onPlayerHealthUpdated();
        }
    }
}
