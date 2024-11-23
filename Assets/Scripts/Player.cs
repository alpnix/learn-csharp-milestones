using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        // Example: Collect an item (triggered by key press here, but should ideally be collision-based)
        if (Input.GetKeyDown(KeyCode.E)) // Replace this with your actual collection logic
        {
            GameManager.Instance.ItemsCollected++;

            // Check win condition
            if (GameManager.Instance.ItemsCollected >= 10)
            {
                UIManager.Instance.ShowWinMessage();
                Time.timeScale = 0; // Pause the game
            }
        }
    }
}
