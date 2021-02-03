using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public ColorBehaviour colorBehaviour { get; set; }
    private int health;
    public string currentColor;

    void Start()
    {
        //StartCoroutine(ColorTimer());
    }

    public void MoveForward()
    {
        transform.Translate(Vector3.left * Time.deltaTime * 5);

        if (transform.position.x < 0)
        {
            Debug.Log("oof");
        }
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
                    break;
                case 1:
                    colorBehaviour = gameObject.AddComponent<ColorGreen>();
                    break;
                case 2:
                    colorBehaviour = gameObject.AddComponent<ColorBlue>();
                    break;
                default:
                    break;
            }
            yield return new WaitForSeconds(3);
        }
        
    }

    public abstract void Die();
    
}
