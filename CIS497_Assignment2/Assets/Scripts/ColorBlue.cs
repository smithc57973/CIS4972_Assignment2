/*
 * Chris Smith
 * ColorBlue
 * Assignment 2
 * A script to change the color to blue.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBlue : ColorBehaviour
{
    public override void ChangeColor()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
    
}
