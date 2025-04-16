using System.Collections;
using UnityEngine;

public class MapSpawnerController : MonoBehaviour
{
    public GameObject maptile;
    public float delay = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnRoutine()
    {

        while(true)
        {
            UnityEngine.Vector3 spawnPos = 
                new UnityEngine.Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
            Instantiate(maptile, spawnPos, maptile.transform.rotation);
            yield return new WaitForSeconds(delay);
        }
    }
}