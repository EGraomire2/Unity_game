using UnityEngine;

public class BonusController : MonoBehaviour
{
    public GameObject menuManager;
    public GameObject score;
    
    public float BonusVelocity;
    private float RealVelocity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.BonusVelocity = 500f;
        float randomSpeedness = UnityEngine.Random.value;
        RealVelocity = BonusVelocity + randomSpeedness * (BonusVelocity / 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (!menuManager.GetComponent<MenuController>().inMenu)
        {
            // Move the asteroid
            this.transform.Translate(0, 0, - RealVelocity * Time.deltaTime, Space.World);
            
            if (this.transform.position.z <= -300){
                Destroy(this.gameObject);
            }
        }
    }
    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.tag == "Player"){
            print("bonus");
            score.GetComponent<ScoreController>().score_total += 200;
        }
    }
}
