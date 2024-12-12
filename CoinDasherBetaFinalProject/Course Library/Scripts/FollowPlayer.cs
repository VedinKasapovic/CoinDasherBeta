using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; // Reference to the player object
    private Vector3 offset = new Vector3(0, 5, -7); // Offset from the player
    public float smoothSpeed = 0.125f; // Smoothing factor

    private void LateUpdate() // Use LateUpdate to avoid lag
    {
        if (player != null) // Check if player is assigned
        {
            // Calculate the desired position with the offset
            Vector3 desiredPosition = player.transform.position + offset;
            // Smoothly interpolate to the desired position
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            // Update the camera's position with the smoothed position
            transform.position = smoothedPosition;
        }
    }
}