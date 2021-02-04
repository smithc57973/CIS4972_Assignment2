/*
 * Chris Smith
 * PlayerController
 * Assignment 2
 * A script to manage player actions.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Color currentColor;
    public GameObject bullet;
    private bool canShoot;

    private void Awake()
    {
        currentColor = Color.red;
        canShoot = true;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentColor = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentColor = Color.green;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentColor = Color.blue;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

        if (Input.GetKeyDown(KeyCode.W) && this.transform.position.y < 11)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1, this.transform.position.z);
        }
        
        if (Input.GetKeyDown(KeyCode.S) && this.transform.position.y > -6.5)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 1, this.transform.position.z);
        }
    }

    void Shoot()
    {
        Vector3 spawn = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
        if (canShoot)
        {
            Instantiate(bullet, spawn, Quaternion.identity);
            canShoot = false;
            StartCoroutine(Cooldown());
        }
    }

    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(.3f);
        canShoot = true;
    }
}
