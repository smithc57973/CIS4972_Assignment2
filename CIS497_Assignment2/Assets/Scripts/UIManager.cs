/*
 * Chris Smith
 * UIManager
 * Assignment 2
 * A script to manage UI elements.
 */ 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text gameOver;
    public Text timer;
    public Text tutorial;
    public int time;
    public GameManager gm;
    
    void Awake()
    {
        time = 30;
        StartCoroutine(Timer());
        gameOver.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.gameStarted)
        {
            tutorial.enabled = false;
        }

        timer.text = "Time: " + time.ToString();
        if (time <= 0)
        {
            gm.gameWon = true;
            gm.gameOver = true;
        }

        if (gm.gameOver)
        {
            if (gm.gameWon)
            {
                gameOver.text = "Game Over! You Win!\nPress R to restart.";
            }
            else
            {
                gameOver.text = "Game Over! You Lose!\nPress R to restart.";
            }
            gameOver.enabled = true;
        }
        
    }

    IEnumerator Timer()
    {
        while (!gm.gameOver)
        {
            yield return new WaitForSeconds(1);
            time -= 1;
        }
        
    }
}
