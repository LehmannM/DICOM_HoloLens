using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetRotation : MonoBehaviour
{

    private bool _rotate = false;

    void Update()
    {

        if (_rotate) //rotate down
        {
            transform.rotation = Quaternion.identity;
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
