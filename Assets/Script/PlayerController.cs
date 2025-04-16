using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Timeline;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private float limit_y = 220;
    private float limit_x = 450;
    public GameObject menu;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      speed = 1000f;
    }

    // Update is called once per frame
    void Update()
    {     
        if (!menu.GetComponent<MenuController>().inMenu)
        {
            // Movements
            if(Input.GetKey(KeyCode.W))
            {
                Vector3 add_vect = Vector3.up * speed * Time.deltaTime;
                if((this.transform.position + add_vect).y <= limit_y + 30)
                {
                    this.transform.position += add_vect;
                }
                else
                {
                    this.transform.position = new Vector3(this.transform.position.x, limit_y+30, this.transform.position.z);
                }
            }
            
            if(Input.GetKey(KeyCode.S))
            {
                Vector3 add_vect = Vector3.down * speed * Time.deltaTime;
                if((this.transform.position + add_vect).y >= -limit_y)
                {
                    this.transform.position += add_vect;
                }
                else
                {
                    this.transform.position = new Vector3(this.transform.position.x, -limit_y, this.transform.position.z);
                }
            }

            if(Input.GetKey(KeyCode.A))
            {
                Vector3 add_vect = Vector3.left * speed * Time.deltaTime;
                if((this.transform.position + add_vect).x >= -limit_x )
                {
                    
                    this.transform.position += add_vect;
                }
                else
                {
                    this.transform.position = new Vector3(-limit_x, this.transform.position.y, this.transform.position.z);
                }
            }

            if(Input.GetKey(KeyCode.D))
            {
                Vector3 add_vect = Vector3.right * speed * Time.deltaTime;
                if((this.transform.position + add_vect).x <= limit_x)
                {
                    
                    this.transform.position += add_vect;
                }
                else
                {
                    this.transform.position = new Vector3(limit_x, this.transform.position.y, this.transform.position.z);
                }        
            }


            // Rotation
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                if(Input.GetKey(KeyCode.A))
                {
                    float angleZ = this.transform.eulerAngles.z; // merci gpt san
                    if (angleZ > 320f || angleZ < 35f)
                    {
                        this.transform.Rotate(0, 0, 100 * Time.deltaTime);
                    }
                }
                
                if(Input.GetKey(KeyCode.D))
                {
                    float angleZ = this.transform.eulerAngles.z;
                    if (angleZ < 40f || angleZ > 325f)
                    {
                        this.transform.Rotate(0, 0, -100 * Time.deltaTime);
                    }
                }
            }
            else
            {
                if(this.transform.rotation.x < 0)
                {
                    this.transform.Rotate(200 * Time.deltaTime, 0, 0);
                }
                if(this.transform.rotation.x > 0)
                {
                    this.transform.Rotate(-200 * Time.deltaTime, 0, 0);
                }
                if(this.transform.rotation.z < 0)
                {
                    this.transform.Rotate(0, 0, 200 * Time.deltaTime);
                }
                if(this.transform.rotation.z > 0)
                {
                    this.transform.Rotate(0, 0, -200 * Time.deltaTime);
                }
                
            }
        }
    }
}