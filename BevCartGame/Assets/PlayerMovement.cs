using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value in the Inspector

    public float jumpForce = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (Input.GetButtonDown("Jump")) // "Jump" is typically mapped to Spacebar
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        
        // Get input for horizontal and vertical movement
        float horizontalInput = Input.GetAxis("Horizontal"); // A/D or Left/Right Arrow
        float verticalInput = Input.GetAxis("Vertical");   // W/S or Up/Down Arrow

        // Calculate movement direction relative to the capsule's forward direction
        Vector3 moveDirection = transform.forward * verticalInput + transform.right * horizontalInput;

        // Normalize the moveDirection to prevent faster diagonal movement
        if (moveDirection.magnitude > 1f)
        {
            moveDirection.Normalize();
        }

        // Apply movement to the capsule's position
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}