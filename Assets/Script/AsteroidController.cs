using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    public GameObject menuManager;
    public float AsteroidVelocity;
    public float AsteroidRotation;

    private float RealVelocity;
    private float randomRotationX;
    private float randomRotationY;
    private float randomRotationZ;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randomSpeedness = UnityEngine.Random.value;
        RealVelocity = AsteroidVelocity + randomSpeedness * (AsteroidVelocity / 2);

        randomRotationX = UnityEngine.Random.value;
        randomRotationY = UnityEngine.Random.value;
        randomRotationZ = UnityEngine.Random.value;
    }

    // Update is called once per frame
    void Update()
    {
        if (!menuManager.GetComponent<MenuController>().inMenu)
        {
            // Move the asteroid
            this.transform.Translate(0, 0, - RealVelocity * Time.deltaTime, Space.World);
            this.transform.Rotate(randomRotationX * AsteroidRotation * Time.deltaTime, randomRotationY * AsteroidRotation * Time.deltaTime, randomRotationZ * AsteroidRotation * Time.deltaTime);
            
            if (this.transform.position.z <= -200){
                Destroy(this.gameObject);
            }
        }
    }
    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.tag == "Player"){
            print("Fin du jeu !");
        }
    }
}
