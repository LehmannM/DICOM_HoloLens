using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{

    //Simple script that allows UI buttons to interact with a gameobject and move it.

    public float panSpeed = 2.0f;       //sets the movementspeed of the object
    bool isMoving0;                     //enable Up
    bool isMoving1;                     //enable Down
    bool isMoving2;                     //enable Forward
    bool isMoving3;                     //enable Backwards
    bool isMoving4;                     //enable Left
    bool isMoving5;                     //Right
    bool isMoving6;                     //Reset
    bool _move0 = false;                //bool to register different buttons of the menu
    bool _move1 = false;
    bool _move2 = false;
    bool _move3 = false;                
    bool _move4 = false;
    bool _move5 = false;
    bool _move6 = false;                

    Vector3 translationAxis; 
    
    /*Update looks if a button was pressed and then moves the object depending on the position of the maincamera(HoloLens)*/

    void Update()
    {

        if (_move0)
        {
            isMoving0 = true;
            if (isMoving0)
            {
                translationAxis = Camera.main.transform.up;
                float distance = panSpeed * Time.deltaTime;
                if (isMoving0) this.transform.position += translationAxis * distance;
            }
        }

        if (_move1)
        {
            isMoving1 = true;
            if (isMoving1)
            {
                translationAxis = Camera.main.transform.up;
                float distance = panSpeed * Time.deltaTime;
                if (isMoving1) this.transform.position -= translationAxis * distance;
            }
        }

        if (_move2)
        {
            isMoving2 = true;
            if (isMoving2)
            {
                translationAxis = Camera.main.transform.forward;
                float distance = panSpeed * Time.deltaTime;
                if (isMoving2) this.transform.position -= translationAxis * distance;
            }
        }

        if (_move3)
        {
            isMoving3 = true;
            if (isMoving3)
            {
                translationAxis = Camera.main.transform.forward;
                float distance = panSpeed * Time.deltaTime;
                if (isMoving3) this.transform.position += translationAxis * distance;
            }
        }

        if (_move4)
        {
            isMoving4 = true;
            if (isMoving4)
            {
                translationAxis = Camera.main.transform.right;
                float distance = panSpeed * Time.deltaTime;
                if(isMoving4) this.transform.position -= translationAxis * distance;
            }
        }

        if (_move5)
        {
            isMoving5 = true;
            if (isMoving5)
            {
                translationAxis = Camera.main.transform.right;
                float distance = panSpeed * Time.deltaTime;
                if (isMoving5) this.transform.position += translationAxis * distance;
            }
        }

        if (_move6)
        { 
            isMoving6 = true;
            if (isMoving6) this.transform.position = new Vector3(0f, 0f, 5f);
        }

    }

    /*To use a UI Button create a new 'Event Trigger' in Unity with 'PointerDown' and 'PointerUp'.
     * Then assign the gameobject with the movement script to the pointer and add Movement.OnPress() to PointerDown and Movement.OnRelese().*/

    public void OnPress0()      //Button 1
    {
        _move0 = true;
    }

    public void OnRelease0()
    {
        _move0 = false;
    }

    public void OnPress1()      //Button 2
    {
        _move1 = true;
    }

    public void OnRelease1()
    {
        _move1 = false;
    }

    public void OnPress2()      //Button 3
    {
        _move2 = true;
    }

    public void OnRelease2()
    {
        _move2 = false;
    }

    public void OnPress3()      //Button 4
    {
        _move3 = true;
    }

    public void OnRelease3()
    {
        _move3 = false;
    }

    public void OnPress4()      //Button 5
    {
        _move4 = true;
    }

    public void OnRelease4()
    {
        _move4 = false;
    }

    public void OnPress5()      //Buton 6
    {
        _move5 = true;
    }

    public void OnRelease5()
    {
        _move5 = false;
    }

    public void OnPress6()      //Button 7
    {
        _move6 = true;
    }

    public void OnRelease6()
    {
        _move6 = false;
    }


}



