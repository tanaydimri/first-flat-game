using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int currentScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        GameEventSystem.Instance.onIncrementScore += IncrementScore;
        GameEventSystem.Instance.onDecrementScore += DecrementScore;
    }

    private void IncrementScore(int incrementFactor)
    {
        currentScore += incrementFactor;
        GameEventSystem.Instance.ScoreUpdated(currentScore);
    }

    private void DecrementScore(int decrementFactor)
    {
        currentScore -= decrementFactor;
        GameEventSystem.Instance.ScoreUpdated(currentScore);
    }
}
