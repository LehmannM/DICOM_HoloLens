using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLeft : MonoBehaviour {

    private bool _rotate;
 
	void Update () {

        if (_rotate) //rotate left
        {
            transform.Rotate(0, 0, -2);
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
