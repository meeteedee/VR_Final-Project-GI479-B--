using UnityEngine;
using UnityEngine.UI;
public class HPBar : MonoBehaviour
{
    public Image hpFill;
    public Health health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hpFill == null || health == null) return;

        hpFill.fillAmount = health.currentHealth / health.MaxHealth;
    }
}
