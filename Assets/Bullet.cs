using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 10f; // Adjust the speed as needed
    public int damage = 1; // Adjust the damage as needed

    void Update()
    {
        // Move the bullet
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        // Destroy the bullet when it goes off-screen (you can adjust this logic)
        if (!GetComponent<Renderer>().isVisible)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the bullet collided with an enemy or other objects
        if (other.CompareTag("Enemy"))
        {
            // Deal damage to the enemy (you can replace this with your own logic)
           // other.GetComponent<EnemyScript>().TakeDamage(damage);

            // Destroy the bullet on collision
            Destroy(gameObject);
        }
    }
}
