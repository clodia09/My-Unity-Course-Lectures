﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleThirdPersonController_Empty : MonoBehaviour
{
    //Which public variables do you need?
    // A Camera
    // A Rotation Speed
    // A Movement Speed
    

    void Update()
    {
        //Get the Input using Input.GetAxis() & assign the values to a new direction Vector3

        //Compute direction According to Camera Orientation (use function TransformDirection)
        //Reference: https://docs.unity3d.com/ScriptReference/Vector3.RotateTowards.html

        //Calculate rotation vector and rotate the object, you can use Quaternion.LookRotation() funcation.
        //Reference: https://docs.unity3d.com/ScriptReference/Quaternion.LookRotation.html

        //Translate along forward

    }
}
