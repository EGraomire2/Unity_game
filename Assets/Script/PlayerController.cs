using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; // Speed of the player movement
    public GameObject bulletPrefab; // Prefab of the bullet to be instantiated
    public float health_point; // Initialize health points
    public bool isInMenu;

    public GameObject gameOverScreen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isInMenu = false;
        health_point = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isInMenu)
        {
            print("On est dans la boucle");
            if (this.health_point <= 0)
            {
                // Destroy the player if health points are less than or equal to zero
                this.gameObject.SetActive(false);
                gameOverScreen.SetActive(true);
                this.isInMenu = true;
                print("Switch de menu");           
            }

            if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && this.transform.position.z < 50)
            {
                // Move player forward
                //this.transform.rotation *= Quaternion.Euler(0, rotation * Time.deltaTime, 0);
                
                this.transform.position += transform.forward * (speed * Time.deltaTime);
            }

            if ((Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.DownArrow)) && this.transform.position.z > 20)
            {
                // Move player backward
                this.transform.position -= transform.forward * (speed * Time.deltaTime);
            }
            if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && this.transform.position.x > -35)
            {
                // Move player left
                //this.transform.rotation *= Quaternion.Euler(0, -rotation * Time.deltaTime, 0);
                this.transform.position -= transform.right * (speed * Time.deltaTime);
            }
            if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && this.transform.position.x < 35)
            {
                // Move player right
                //this.transform.rotation *= Quaternion.Euler(0, rotation * Time.deltaTime, 0);
                this.transform.position += transform.right * (speed * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Shoot ! 
                Instantiate(bulletPrefab, this.transform.position + transform.forward, this.transform.rotation);
            }
        }
    }

    public void takeDamage(int x){
        this.health_point -= x;
    }
}
