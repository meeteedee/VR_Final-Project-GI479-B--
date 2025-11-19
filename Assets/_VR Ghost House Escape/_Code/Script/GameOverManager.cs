using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverUI; // Panel ที่เขียนว่า You Died หรือ Game Over
    public GameObject youSurvivedUI; // ถ้าไว้ใช้ตอนหนีออกทางประตูได้

    public void ShowGameOver()
    {
        if (gameOverUI != null)
            gameOverUI.SetActive(true);

        Time.timeScale = 0f; // หยุดเกม
        Debug.Log("GAME OVER");
    }

    public void ShowYouSurvived()
    {
        if (youSurvivedUI != null)
            youSurvivedUI.SetActive(true);

        Time.timeScale = 0f;
        Debug.Log("YOU SURVIVED");
    }
}