using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBlue : ColorBehaviour
{
    public override void ChangeColor()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
