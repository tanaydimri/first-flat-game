using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUiManager : MonoBehaviour
{
    public TextMeshProUGUI scoreValueUi;

    // Start is called before the first frame update
    void Start()
    {
        GameEventSystem.current.onScoreUpdated += updateScoreValue;
    }

    private void updateScoreValue(int currentScore)
    {
        scoreValueUi.text = currentScore.ToString();
    }
}
