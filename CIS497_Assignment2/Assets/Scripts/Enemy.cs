/*
 * Chris Smith
 * Enemy
 * Assignment 2
 * An abstract class defining Enemy objects.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public ColorBehaviour colorBehaviour { get; set; }
    public int health;
    public Color currentColor;
    private Rigidbody rb;
    public GameManager gm;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    public void MoveForward()
    {
        rb.AddForce(Vector3.left.normalized * Time.deltaTime * 25);
    }
    
    public virtual void DoChangeColor()
    {
        colorBehaviour.ChangeColor();
    }

    public IEnumerator ColorTimer()
    {
        while (true)
        {
            Destroy(GetComponent<ColorBehaviour>());
            int i = Random.Range(0, 3);
            switch (i)
            {
                case 0:
                    colorBehaviour = gameObject.AddComponent<ColorRed>();
                    currentColor = Color.red;
                    gameObject.layer = LayerMask.NameToLayer("red");
                    break;
                case 1:
                    colorBehaviour = gameObject.AddComponent<ColorGreen>();
                    currentColor = Color.green;
                    gameObject.layer = LayerMask.NameToLayer("green");
                    break;
                case 2:
                    colorBehaviour = gameObject.AddComponent<ColorBlue>();
                    currentColor = Color.blue;
                    gameObject.layer = LayerMask.NameToLayer("blue");
                    break;
                default:
                    break;
            }
            DoChangeColor();
            yield return new WaitForSeconds(3);
        }
        
    }

    public abstract void Die();
    
}
