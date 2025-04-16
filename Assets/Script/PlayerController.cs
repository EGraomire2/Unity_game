using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      speed = 1000f;
    }

    // Update is called once per frame
    void Update()
    {     
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S))
        {
            this.transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A))
        {
            this.transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D))
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}