using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed = 20.0f; // Ensure speed has a default value, or set it in the inspector

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}