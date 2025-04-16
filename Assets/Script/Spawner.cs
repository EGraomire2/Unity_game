using UnityEngine;
using System.Collections; // Required for using IEnumerator

public class EnemySpawner : MonoBehaviour
{
    // Prefab des asteroids
    public GameObject asteroid01;
    public GameObject asteroid02; 
    public GameObject asteroid03; 
    public GameObject asteroid04; 
    public GameObject asteroid05; 
    public GameObject asteroid06; 
    public GameObject asteroid07; 
    public GameObject asteroid08; 
    public GameObject asteroid09; 
    public GameObject player; // Reference to the player object
    public GameObject menuManager;
    public float spawnInterval; // Time interval between enemy spawns
    public float delayRange;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnInterval = 2f;
        delayRange = 0.5f;
        StartCoroutine(SpawnRoutine()); // Start the spawn routine coroutine
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            if (!menuManager.GetComponent<MenuController>().inMenu){
                
                // On rend le spawn de plus en plus rapide
                if (spawnInterval > 0.7f){
                    spawnInterval -= 0.025f;
                    delayRange -= 0.01f;}

                float effectiveDelay = spawnInterval + delayRange * UnityEngine.Random.value;

                // Generation de nombres random entre 0 et 1
                float randomPositionX = UnityEngine.Random.value; 
                float randomPositionY = UnityEngine.Random.value;
                float randomRotationX = UnityEngine.Random.value;
                float randomRotationY = UnityEngine.Random.value;
                float randomRotationZ = UnityEngine.Random.value;
                
                System.Random random = new System.Random();
                int idAsteroid = random.Next(1, 10); // 1 inclus, 10 exclus => donc 1 à 9 inclus
                
                GameObject newAsteroid = null;
                switch(idAsteroid)
                {
                    case 1:{                  
                        newAsteroid = Instantiate(asteroid01, new Vector3((randomPositionX - 0.5f) * 100, (randomPositionY - 0.5f) * 100, 300),
                        Quaternion.Euler(randomRotationX * 360, randomRotationY * 360, randomRotationZ * 360));
                        break;}
                    case 2:{
                        newAsteroid = Instantiate(asteroid02, new Vector3((randomPositionX - 0.5f) * 100, (randomPositionY - 0.5f) * 100, 300),
                        Quaternion.Euler(randomRotationX * 360, randomRotationY * 360, randomRotationZ * 360));
                        break;}
                    case 3:{
                        newAsteroid = Instantiate(asteroid03, new Vector3((randomPositionX - 0.5f) * 100, (randomPositionY - 0.5f) * 100, 300),
                        Quaternion.Euler(randomRotationX * 360, randomRotationY * 360, randomRotationZ * 360));
                        break;}
                    case 4:{
                        newAsteroid = Instantiate(asteroid04, new Vector3((randomPositionX - 0.5f) * 100, (randomPositionY - 0.5f) * 100, 300),
                        Quaternion.Euler(randomRotationX * 360, randomRotationY * 360, randomRotationZ * 360));
                        break;}
                    case 5:{
                        newAsteroid = Instantiate(asteroid05, new Vector3((randomPositionX - 0.5f) * 100, (randomPositionY - 0.5f) * 100, 300),
                        Quaternion.Euler(randomRotationX * 360, randomRotationY * 360, randomRotationZ * 360));
                        break;}
                    case 6:{
                        newAsteroid = Instantiate(asteroid06, new Vector3((randomPositionX - 0.5f) * 100, (randomPositionY - 0.5f) * 100, 300),
                        Quaternion.Euler(randomRotationX * 360, randomRotationY * 360, randomRotationZ * 360));
                        break;}
                    case 7:{
                        newAsteroid = Instantiate(asteroid07, new Vector3((randomPositionX - 0.5f) * 100, (randomPositionY - 0.5f) * 100, 300),
                        Quaternion.Euler(randomRotationX * 360, randomRotationY * 360, randomRotationZ * 360));
                        break;}
                    case 8:{
                        newAsteroid = Instantiate(asteroid08, new Vector3((randomPositionX - 0.5f) * 100, (randomPositionY - 0.5f) * 100, 300),
                        Quaternion.Euler(randomRotationX * 360, randomRotationY * 360, randomRotationZ * 360));
                        break;}
                    case 9:{
                        newAsteroid = Instantiate(asteroid09, new Vector3((randomPositionX - 0.5f) * 100, (randomPositionY - 0.5f) * 100, 300),
                        Quaternion.Euler(randomRotationX * 360, randomRotationY * 360, randomRotationZ * 360));
                        break;}
                } 
                newAsteroid.GetComponent<AsteroidController>().menuManager = menuManager;

                yield return new WaitForSeconds(effectiveDelay); // Wait for 2 seconds before starting the spawn loop
            }
            yield return null;
        }
    }
}

