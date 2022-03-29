using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    private int _currentSceneIndex = 1;
    private bool _mainMenuVisible = true;

    public void LoadCurrentLevel() 
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(_currentSceneIndex);
        _mainMenuVisible = true;
    }

    public void SetCurrentLevel(int newSceneIndex)
    {
        if (newSceneIndex == 0)
        {
            return;
        }

        _currentSceneIndex = newSceneIndex;
    }

    void ShowMainMenu()
    {
        transform.gameObject.GetComponent<Canvas>().enabled = true;
    }

    void HideMainMenu()
    {
        transform.gameObject.GetComponent<Canvas>().enabled = false;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            GameObject MainMenuGO = GameObject.FindGameObjectWithTag("MainMenu");
            if (MainMenuGO == null)
            {
                return;
            }

            Debug.Log("Toggling Main Menu");
            _mainMenuVisible = MainMenuGO.GetComponent<Canvas>().enabled;
            MainMenuGO.GetComponent<Canvas>().enabled = !_mainMenuVisible;
        }
    }
}
