using UnityEngine;

public class ExitZone : MonoBehaviour
{
    public GameObject youSurvivedUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ShowWin();
        }
    }

    void ShowWin()
    {
        if (youSurvivedUI != null)
            youSurvivedUI.SetActive(true);

        // หยุดการควบคุมผู้เล่น (ถ้าต้องการ)
        Time.timeScale = 0f;

        Debug.Log("YOU SURVIVED!");
    }
}
