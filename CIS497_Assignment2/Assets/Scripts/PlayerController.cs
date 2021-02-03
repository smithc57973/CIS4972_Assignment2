using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Color currentColor;
    public GameObject bullet;

    private void Awake()
    {
        currentColor = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentColor = Color.red;
            Debug.Log("red");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentColor = Color.green;
            Debug.Log("green");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentColor = Color.blue;
            Debug.Log("blue");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("fire");
            Shoot();
        }

        if (Input.GetKeyDown(KeyCode.W) && this.transform.position.y < 6)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1, this.transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.S) && this.transform.position.y > -4)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 1, this.transform.position.z);
        }
    }

    void Shoot()
    {
        Instantiate(bullet, this.transform.position, Quaternion.identity);
    }
}
