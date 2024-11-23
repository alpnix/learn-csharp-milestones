using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    void FixedUpdate()
    {
        float moveSpeed = 5f;

        // Move using physics
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.W))
            rb.MovePosition(transform.position + transform.forward * moveSpeed * Time.fixedDeltaTime);
        
        Vector3 newPosition = transform.position + transform.forward * 5f * Time.fixedDeltaTime;
        rb.MovePosition(newPosition);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collided with: {collision.gameObject.name}");

        if (collision.gameObject.CompareTag("Obstacle"))
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

    }

    // Update is called once per frame
    void Update()
    {
        float curTime = Time.time;
        if (Input.GetKey(KeyCode.W)) // Move forward
        {
            Debug.Log("W key is pressed!");
        }

        float moveSpeed = 5f;
        float rotateSpeed = 50f;

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
    }
}
