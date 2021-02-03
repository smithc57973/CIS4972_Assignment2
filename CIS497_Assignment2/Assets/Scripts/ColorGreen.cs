using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGreen : ColorBehaviour
{
    public override void ChangeColor()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
