using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    private ColorBehaviour colorBehaviour;
    private int health;

    public string currentColor;

    void MoveForward()
    {
        transform.Translate(Vector3.left * Time.deltaTime * 5);

        if (transform.position.x < 0)
        {
            Debug.Log("oof");
        }
    }

    void SetColorBehaviour()
    {

    }

    ColorBehaviour GetColorBehaviour()
    {
        return null;
    }

    public virtual void DoChangeColor()
    {

    }

    public abstract void Die();
    
}
