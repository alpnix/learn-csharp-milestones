using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public enum PlayerAction { Jump, Move }

// void Update()
// {
//     if (Input.GetKeyDown(KeyCode.Space))
//     {
//         Debug.Log($"{PlayerAction.Jump} triggered!");
//     }
// }


public class Move : MonoBehaviour
{

    public LayerMask groundLayer;
    public float jumpForce = 5f;

    void FixedUpdate()
    {
        float moveSpeed = 5f;

        // Move using physics
        // Rigidbody rb = GetComponent<Rigidbody>();
        // if (Input.GetKey(KeyCode.W))
            // rb.MovePosition(transform.position + transform.forward * moveSpeed * Time.fixedDeltaTime);
        
        // Vector3 newPosition = transform.position + transform.forward * 5f * Time.fixedDeltaTime;
        // rb.MovePosition(newPosition);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collided with: {collision.gameObject.name}");

        if (collision.gameObject.CompareTag("Cube 2"))
        {
            Destroy(collision.gameObject); // Destroys the other object
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Entered Trigger with: {other.gameObject.name}");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log($"Exited Trigger with: {other.gameObject.name}");
    }



    void Start()
    {
        // Rigidbody rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float curTime = Time.time;
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.W)) // Move forward
        {
            Debug.Log("W key is pressed!");
        }

        float moveSpeed = 5f;
        float rotateSpeed = 0.5f;

        // Move forward/backward
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

        // Rotate left/right
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 1.1f, groundLayer);
    }
}
