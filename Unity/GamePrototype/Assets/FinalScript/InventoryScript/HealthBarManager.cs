using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarManager : MonoBehaviour
{
    public GameObject staminaBar;
    public GameObject healthBar;
    public GameObject player;
    public int MaxWidth;
    [Space]
    public Text healthText;
    public Text staminaText;

    StatsManager statsManager;

    // Start is called before the first frame update
    void Start()
    {
        statsManager = player.GetComponent<StatsManager>();
    }

    void FixedUpdate()
    {
        healthBar.GetComponent<RectTransform>().sizeDelta = new Vector2((statsManager.Vitality/ statsManager.MaxVitality*280), 35);
        staminaBar.GetComponent<RectTransform>().sizeDelta = new Vector2((statsManager.Stamina / statsManager.MaxStamina * 280), 35);

        healthText.text = statsManager.MaxVitality.ToString() + "/" + statsManager.Vitality.ToString();
        staminaText.text = statsManager.MaxStamina.ToString() + "/" + statsManager.Stamina.ToString();
    }
    
}
