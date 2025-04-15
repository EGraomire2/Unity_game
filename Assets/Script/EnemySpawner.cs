using UnityEngine;
using System.Collections; // Required for using IEnumerator

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy; // Prefab of the enemy to be instantiated
    public GameObject player; // Reference to the player object
    public GameObject menu; // Reference to the player object
    public float spawnInterval = 1f; // Time interval between enemy spawns
    public float delayRange = 0.5f;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnRoutine()); // Start the spawn routine coroutine
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            if (!menu.GetComponent<MenuController>().isMenu){
                if (spawnInterval > 0.5f){
                    spawnInterval -= 0.1f;
                    delayRange -= 0.05f;}

                float effectiveDelay = spawnInterval + delayRange * UnityEngine.Random.value;
                float randomValue = UnityEngine.Random.value; // Generate a random value between 0 and 1
                GameObject newEnnemy = Instantiate(enemy, new Vector3(0, player.transform.position.y, player.transform.position.z) + new Vector3((randomValue - 0.5f) * 70, 0, 200), this.transform.rotation); // Instantiate the enemy prefab at the spawner's position
                // Donner la référence du joueur à enwEnnemy
                newEnnemy.GetComponent<EnemyController>().player = this.player;

                yield return new WaitForSeconds(effectiveDelay); // Wait for 2 seconds before starting the spawn loop
            }
            yield return null;
        }
    }
}
