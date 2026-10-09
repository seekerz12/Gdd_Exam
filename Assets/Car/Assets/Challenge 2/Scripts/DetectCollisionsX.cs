using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Only destroy objects if the thing we hit is tagged "Ball"
        if (other.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}