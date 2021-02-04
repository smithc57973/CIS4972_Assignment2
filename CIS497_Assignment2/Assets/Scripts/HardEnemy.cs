/*
 * Chris Smith
 * HardEnemy
 * Assignment 2
 * A script to manage hard type enemies.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardEnemy : Enemy
{
    public override void Die()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    public void Start()
    {
        StartCoroutine(ColorTimer());
        health = 3;
    }

    // Update is called once per frame
    public void Update()
    {
        MoveForward();
        if (health <= 0)
        {
            Die();
        }

        if (transform.position.x < -25)
        {
            gm.gameOver = true;
        }
    }
}
