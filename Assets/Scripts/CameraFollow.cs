using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Drag the player GameObject to this field in the Inspector
    public Vector3 offset;   // Adjust the offset in the Inspector

    void LateUpdate()
    {
        // Make the camera follow the player
        transform.position = player.position + offset;

        // Make the camera look at the player
        transform.LookAt(player);
    }
}
