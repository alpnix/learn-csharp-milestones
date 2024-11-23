using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    // Singleton instance for global access
    public static GameManager Instance { get; private set; }

    // Game properties with get and set
    private int health;
    public int Health
    {
        get { return health; }
        set
        {
            health = Mathf.Clamp(value, 0, 100); // Ensure health stays between 0 and 100
            UIManager.Instance.UpdateHealthUI(health); // Update UI when health changes
        }
    }

    private int itemsCollected;
    public int ItemsCollected
    {
        get { return itemsCollected; }
        set
        {
            itemsCollected = value;
            UIManager.Instance.UpdateItemsUI(itemsCollected); // Update UI when item count changes
        }
    }

    void Awake()
    {
        // Singleton pattern
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Keep GameManager across scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
