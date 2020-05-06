﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreDisplay;
    // Start is called before the first frame update
    void Start()
    {
        scoreDisplay.text = score.ToString();   
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = score.ToString();   
    }
    void OnTriggerEnter2D(Collider2D other) {

        if(other.CompareTag("Obstacle")){
            score = score + 1;
        }
    }
}