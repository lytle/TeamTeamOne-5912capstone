﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePoker : MonoBehaviour
{
    private const float ShowTime = 2;
    private float timer;
    public int scoreNum;
    
    public Text Score;
	// Use this for initialization
	void Start ()
    {
		Reset();
	}
	
	// Update is called once per frame
	void Update ()
	{
        if(PauseManager.Paused)return;
	    if (timer > 0)
	    {
	        timer -= Time.deltaTime;
	        if (timer < 0) Score.gameObject.SetActive(false);
        }
        
	}

    public void Scored()
    {
        scoreNum++;
        Score.text = scoreNum.ToString();
        Score.gameObject.SetActive(true);
        timer = ShowTime;
    }

    public void Reset()
    {
        scoreNum = 0;
        Score.text = scoreNum.ToString();
        Score.gameObject.SetActive(false);
        timer = 0;
    }
}
