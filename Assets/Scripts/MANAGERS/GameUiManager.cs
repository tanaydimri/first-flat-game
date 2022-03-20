using UnityEngine;
using TMPro;

public class GameUiManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreValueUi;
    [SerializeField] private TextMeshProUGUI healthValueUi;

    // Start is called before the first frame update
    void Start()
    {
        GameEventSystem.Instance.onScoreUpdated += UpdateScoreInUi;
        GameEventSystem.Instance.onPlayerHealthUpdated += UpdatePlayerHealthInUi;
        UpdatePlayerHealthInUi();
    }

    private void UpdateScoreInUi(int currentScore)
    {
        scoreValueUi.text = currentScore.ToString();
    }

    private void UpdatePlayerHealthInUi()
    {
        healthValueUi.text = PlayerHealth.current.playerHealth.ToString();
    }
}
