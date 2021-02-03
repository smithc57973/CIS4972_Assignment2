using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private string currentColor;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentColor = "red";
            Debug.Log("red");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentColor = "green";
            Debug.Log("green");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentColor = "blue";
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

        /*Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            //we can pass in super-types like super-classes,
            //abstract classes, and interfaces to GetComponent<SupertypeName>()
            Enemy objectHit = hit.collider.GetComponent<Enemy>();  //here we pass in an interface

            if (objectHit != null && currentColor == objectHit.currentColor)
            {
                //Calls the Die() method on the hit Enemy object
                objectHit.Die();
            }
        }*/

    }
}
