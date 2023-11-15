using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 5f; // Adjust the speed as needed
    public float rotationSpeed = 200f; // Adjust the rotation speed as needed
    public GameObject bulletPrefab; // Reference to the bullet prefab
    public Transform firePoint; // Reference to the point where the bullets will be spawned


    void Update()
    {
        // Get player input
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Move the character
        Vector3 movement = new Vector3(horizontal, vertical, 0f);
        transform.position += movement * speed * Time.deltaTime;

         // Rotate the character based on input
        if (movement != Vector3.zero)
        {
            float angle = Mathf.Atan2(movement.x, movement.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0f, 0f, -angle), rotationSpeed * Time.deltaTime);
        }

        // Shooting mechanism
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instantiate a bullet at the fire point
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        // Add any additional logic for shooting, such as play sound effects, animations, etc.
    }
}