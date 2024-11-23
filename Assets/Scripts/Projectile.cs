using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 0.5f;
    public GameObject projectilePrefab;
    public Transform firePoint;

    void Awake()
    {
        // Assign firePoint here if it's not set in the Inspector
        if (firePoint == null)
        {
            firePoint = GameObject.Find("Particle System").transform; // Ensure "FirePoint" exists in the scene
        }
    }


    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left-click
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = transform.forward * speed;
            if (firePoint != null && projectilePrefab != null)
            {
                GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
                Destroy(projectile, 3f);
            }

        }
    }
}