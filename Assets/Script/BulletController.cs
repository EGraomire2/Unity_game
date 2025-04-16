using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed; // Speed of the bullet movement

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Destroy the bullet after 5 seconds to prevent it from existing indefinitely
        Destroy(this.gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        // Move the bullet forward
        this.transform.position += transform.forward * (speed * Time.deltaTime);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the bullet collides with an object tagged as "Enemy"
        if (collision.gameObject.tag == "Enemy")
        {
            // Destroy the enemy on collision
            collision.gameObject.GetComponent<EnemyController>().health_point -= 50; // Decrease enemy health points by 10
            
            // Destroy the bullet 
            Destroy(this.gameObject);
        }
    }
}
