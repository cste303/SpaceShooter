using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 3f;
    public int health = 3; // Adjust the health as needed

    void Update()
    {
        // Example: Move the enemy forward
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // Destroy the bullet when it goes off-screen (you can adjust this logic)
        if (!GetComponent<Renderer>().isVisible)
        {
            Destroy(gameObject);
        }
        // Add additional logic for enemy behavior, such as detecting the player

    }

    public void TakeDamage(int damage)
    {
        // Example: Reduce health when the enemy takes damage
        health -= damage;

        if (health <= 0)
        {
            // Example: Destroy the enemy when its health reaches zero
            Destroy(gameObject);
        }
    }
}
