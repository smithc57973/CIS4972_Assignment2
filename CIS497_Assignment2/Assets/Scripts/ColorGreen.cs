/*
 * Chris Smith
 * ColorGreen
 * Assignment 2
 * A script to change the color to green.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGreen : ColorBehaviour
{
    public override void ChangeColor()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
    }
    
}
