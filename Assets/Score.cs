using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtScore;
    public int scorePts;
    // Start is called before the first frame update
    void Start()
    {
        scorePts = 0;
        ScoreUpdate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoints(int points)
    {
        scorePts += points;
        ScoreUpdate();
    }

    public void ScoreUpdate()
    {
        txtScore.text = scorePts.ToString();
    }
}

