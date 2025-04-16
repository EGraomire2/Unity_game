using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
    public float health_point; // Initialize health points
    public float speed; // Speed of the enemy movement
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.GetComponent<PlayerController>().isInMenu){
            if (this.health_point <= 0)
            {
                // Destroy the enemy if health points are less than or equal to zero
                Destroy(this.gameObject);            
            }


            if (this.transform.position.z < 10){
                player.GetComponent<PlayerController>().takeDamage(50);
                Destroy(this.gameObject);
            }

            // Move the asteroid
            this.transform.position -= transform.forward * (speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the enemy collides with an object tagged as "Player"
        print("Il y a une collision !"); // Print a message to the console
        if (collision.gameObject.tag == "Player")
        {
            print("Player hit!"); // Print a message to the console
            collision.gameObject.GetComponent<PlayerController>().takeDamage(30); 
            Destroy(this.gameObject); // Destroy the enemy on collision with the player
        }
    }
    
}
