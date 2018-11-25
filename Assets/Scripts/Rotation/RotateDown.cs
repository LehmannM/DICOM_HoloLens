using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDown : MonoBehaviour {

    private bool _rotate;
	
	void Update () {

        if (_rotate) //rotate down
        {
            transform.Rotate(-2, 0, 0);
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
