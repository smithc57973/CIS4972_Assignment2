/*
 * Chris Smith
 * ColorRed
 * Assignment 2
 * A script to change the color to red.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRed : ColorBehaviour
{
    public override void ChangeColor()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    
}
