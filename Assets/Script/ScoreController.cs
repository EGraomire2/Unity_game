using System.Collections;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public int score_total = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Update_Score());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Update_Score()
    {
        while(true)
        {
            score_total++;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
