using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    public Text healthText;
    public Text itemsText;
    public Text winText;

    void Awake()
    {
        // Singleton pattern
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void UpdateHealthUI(int health)
    {
        healthText.text = "Health: " + health;
    }

    public void UpdateItemsUI(int items)
    {
        itemsText.text = "Items: " + items;
    }

    public void ShowWinMessage()
    {
        winText.gameObject.SetActive(true);
        winText.text = "You Win!";
    }
}
