using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30.0f; // Changed to a negative value for the left boundary
    private float rightLimit = 30.0f; // Added right limit just in case
    private float bottomLimit = -5.0f;

    void Update()
    {
        // Destroy dogs if x position leaves the screen limits
        if (transform.position.x < leftLimit || transform.position.x > rightLimit)
        {
            Destroy(gameObject);
        }
        // Destroy balls if y position (not z) is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Debug.Log("Game Over!"); // Added the Game Over debug message
            Destroy(gameObject);
        }
    }
}