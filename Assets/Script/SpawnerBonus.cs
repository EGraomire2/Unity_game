using UnityEngine;
using System.Collections; // Required for using IEnumerator

public class SpawnerBonus : MonoBehaviour
{
    // Prefab des asteroids
    public GameObject bonus;
    public GameObject player; // Reference to the player object
    public GameObject menuManager;
    public float spawnInterval; // Time interval between enemy spawns
    public float delayRange;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnInterval = 15f;
        delayRange = 0.5f;
        StartCoroutine(SpawnRoutine()); // Start the spawn routine coroutine
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            if (!menuManager.GetComponent<MenuController>().inMenu)
            {
                float effectiveDelay = spawnInterval + delayRange * UnityEngine.Random.value;

                // Generation de nombres random entre 0 et 1
                float randomPositionX = UnityEngine.Random.value; 
                float randomPositionY = UnityEngine.Random.value;

                GameObject newBonus = null;
              
                newBonus = Instantiate(bonus, new Vector3((randomPositionX - 0.5f) * 200, (randomPositionY - 0.5f) * 200, 1000),
                Quaternion.Euler(90, 0, 0));
                    
                newBonus.GetComponent<BonusController>().menuManager = menuManager;

                yield return new WaitForSeconds(effectiveDelay); // Wait for 2 seconds before starting the spawn loop
            }
            yield return null;
        }
    }
}

