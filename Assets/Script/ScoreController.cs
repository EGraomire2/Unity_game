using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public int score_total;
    public TextMeshProUGUI t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score_total = 0;
        StartCoroutine(Update_Score());
    }

    // Update is called once per frame
    void Update()
    {
        //t.text = score_total.ToString();
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

