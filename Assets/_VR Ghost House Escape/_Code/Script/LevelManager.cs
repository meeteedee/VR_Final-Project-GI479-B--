using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private string startLevel;

    public void LoadStartLevelScene()
    {
        SceneManager.LoadScene(startLevel);
    }
}
