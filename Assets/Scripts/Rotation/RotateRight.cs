﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRight : MonoBehaviour {

    private bool _rotate;
  
	void Update () {

        if (_rotate) //rotate right
        {
            transform.Rotate(0, 0, 2);
        }

    }

    public void OnPress() //For UI Button, check if the Button is pressed
    {
        _rotate = true;
    }

    public void OnRelease() //For UI Button, check if Button is not pressed
    {
        _rotate = false;
    }
}
