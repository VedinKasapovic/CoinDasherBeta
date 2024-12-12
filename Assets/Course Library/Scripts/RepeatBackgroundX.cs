using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackgroundX : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatLength;

    private void Start()
    {
        startPos = transform.position; // Starting position
        repeatLength = GetComponent<BoxCollider>().size.x; // Use full collider width
    }

    private void Update()
    {
        // If background has moved left by its full width, reset its position
        if (transform.position.x < startPos.x - repeatLength)
        {
            transform.position = startPos;
        }
    }
}
