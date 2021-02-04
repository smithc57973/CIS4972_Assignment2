/*
 * Chris Smith
 * GameManager
 * Assignment 2
 * A script to manage game state.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameOver;
    public bool gameWon;
    public bool gameStarted;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        gameWon = false;
        gameStarted = false;
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            gameStarted = true;
            Time.timeScale = 1f;
        }
        if (gameOver)
        {
            Time.timeScale = 0f;
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
