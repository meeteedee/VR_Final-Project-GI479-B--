using UnityEngine;

public class MainMenuUIManager : MonoBehaviour
{
    LevelManager levelManager;

    private void Awake()
    {
        levelManager = FindFirstObjectByType<LevelManager>();
    }

    public void LoadStartLevel()
    {
        levelManager.LoadStartLevelScene();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
