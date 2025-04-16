using UnityEngine;

public class MapController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += Vector3.back * speed * Time.deltaTime;
    }
}