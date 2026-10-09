using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    public float turnSpeed = 45.0f;

    void Start()
    {
        
    }

    void Update()
    {
        // Get horizontal axis input (A/D or Left/Right arrows)
        float horizontalInput = Input.GetAxis("Horizontal");

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // Turn the vehicle based on player input
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}