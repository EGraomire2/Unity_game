using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 100f;
    public float zFixe = 20f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKey(KeyCode.W))
        {
            this.transform.position += Vector3.up * (speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
            this.transform.position += Vector3.down * (speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))
        {
            this.transform.position += Vector3.left * (speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            this.transform.position += Vector3.right * (speed * Time.deltaTime);
        }*/

        // this.transform.position = Vector3.MoveTowards(this.transform.position, Input.mousePosition, speed * Time.deltaTime);

        // Récupère la position de la souris en pixels et ajoute une profondeur Z
        Vector3 sourisEcran = Input.mousePosition;
        sourisEcran.z = Mathf.Abs(Camera.main.transform.position.z); // ou une autre profondeur si tu veux

        // Convertir en position dans le monde
        Vector3 cible = Camera.main.ScreenToWorldPoint(sourisEcran);

        // Fixer la valeur de Z
        cible.z = 0f; // ou toute autre valeur que tu veux fixer

        // Déplacer l'objet vers la position de la souris
        this.transform.position = Vector3.MoveTowards(this.transform.position, cible, speed * Time.deltaTime);
    }
}
