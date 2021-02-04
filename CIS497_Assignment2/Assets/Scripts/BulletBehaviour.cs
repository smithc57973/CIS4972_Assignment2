/*
 * Chris Smith
 * BulletBehaviour
 * Assignment 2
 * A script to manage bullet projectiles and properties.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    private PlayerController pc;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        GetComponent<MeshRenderer>().material.color = pc.currentColor;
        if (pc.currentColor == Color.red)
        {
            gameObject.layer = LayerMask.NameToLayer("red");
        }
        else if (pc.currentColor == Color.green)
        {
            gameObject.layer = LayerMask.NameToLayer("green");
        }
        else if (pc.currentColor == Color.blue)
        {
            gameObject.layer = LayerMask.NameToLayer("blue");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.right * Time.deltaTime * 5);
        rb.AddForce(Vector3.right.normalized * Time.deltaTime * 200);

        if (transform.position.x > 10)
        {
            Destroy(gameObject);
        }
    }
    
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<Enemy>() != null)
        {
            if (col.gameObject.GetComponent<Enemy>().currentColor == this.GetComponent<MeshRenderer>().material.color)
            {
                Destroy(gameObject);
                col.gameObject.GetComponent<Enemy>().health--;
            }
        }
    }
}
