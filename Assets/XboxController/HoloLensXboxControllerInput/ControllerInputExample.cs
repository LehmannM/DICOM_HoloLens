using UnityEngine;
using System.Collections;
using System.Text;
using UnityEngine.UI;
// Needed
using HoloLensXboxController;


public class ControllerInputExample : MonoBehaviour {
    
    // Needed 
    public ControllerInput controllerInput;

    //Renderer for slicing
    Renderer Rend;

    //Sliders for the value needed to slice the Data Cube
    Slider slider1;
    Slider slider2;
    Slider slider3;
    Slider slider4;
    Slider slider5;
    Slider slider6;
    
    //Float for slicing speed
    public float sliceSpeed = 0.1f;

    //Slider for the value needed to change stretchpower value
    Slider stretchpower;

    //Float for stretch speed
    public float stretchspeed = 0.5f;

    
    public void Start () {
        
        // Needed 
        // First parameter is the number, starting at zero, of the controller you want to follow.
        // Second parameter is the default “dead” value; meaning all stick readings less than this value will be set to 0.0.
        controllerInput = new ControllerInput(0, 0.19f);

        //Renderer for Slicing
        Rend = GetComponent<Renderer>();

        //Create temp. GameObject for the Sliders
        //Slider front/back
        GameObject temp1 = GameObject.Find("slider1");
        if (temp1 != null)
        {
            slider1 = temp1.GetComponent<Slider>();    
        }
        
        //Slider back/front
        GameObject temp2 = GameObject.Find("slider2");
        if (temp2 != null)
        {
            slider2 = temp2.GetComponent<Slider>();
        }

        //Slider top/buttom
        GameObject temp3 = GameObject.Find("slider3");
        if (temp3 != null)
        {
            slider3 = temp3.GetComponent<Slider>();
        }

        //Slider buttom/top
        GameObject temp4 = GameObject.Find("slider4");
        if (temp4 != null)
        {
            slider4 = temp4.GetComponent<Slider>();
        }

        //Slider left/right
        GameObject temp5 = GameObject.Find("slider5");
        if (temp5 != null)
        { 
            slider5 = temp5.GetComponent<Slider>();
        }

        //Slider right/left
        GameObject temp6 = GameObject.Find("slider6");
        if (temp6 != null)
        {
            slider6 = temp6.GetComponent<Slider>();
        }

        //Slider stretchpower
        GameObject temp7 = GameObject.Find("stretchpower");
        if (temp7 != null)
        {
            stretchpower = temp7.GetComponent<Slider>();
        }
    }  

    public void Update () {
        // Needed 
        controllerInput.Update();
        
        translateRotateScale();

        //Update the material with changed values
        Rend.material.SetFloat("_SliceAxis1Min", slider1.value);
        Rend.material.SetFloat("_SliceAxis1Max", slider2.value);
        Rend.material.SetFloat("_SliceAxis2Min", slider3.value);
        Rend.material.SetFloat("_SliceAxis2Max", slider4.value);
        Rend.material.SetFloat("_SliceAxis3Min", slider5.value);
        Rend.material.SetFloat("_SliceAxis3Max", slider6.value);
        Rend.material.SetFloat("_StretchPower", stretchpower.value);

        //Slice from front to back
        if (slider1 != null)
        {
            if(controllerInput.GetButtonDown(ControllerButton.DPadDown) && controllerInput.GetButton(ControllerButton.A))
                slider1.value = slider1.value + (sliceSpeed * Time.deltaTime);
            if (controllerInput.GetButtonDown(ControllerButton.DPadUp) && controllerInput.GetButton(ControllerButton.A))
                slider1.value = slider1.value - (sliceSpeed * Time.deltaTime);
        }

        //Slice from back to front
        if (slider2 != null)
        {
            if(controllerInput.GetButtonDown(ControllerButton.DPadLeft) && controllerInput.GetButton(ControllerButton.A))
                slider2.value = slider2.value - (sliceSpeed * Time.deltaTime);
            if(controllerInput.GetButtonDown(ControllerButton.DPadRight) && controllerInput.GetButton(ControllerButton.A))
                slider2.value = slider2.value + (sliceSpeed * Time.deltaTime);
        }

        //Slice from top to buttom
        if (slider3 != null)
        {
            if(controllerInput.GetButtonDown(ControllerButton.DPadDown) && controllerInput.GetButton(ControllerButton.B))
                slider3.value = slider3.value + (sliceSpeed * Time.deltaTime);
            if(controllerInput.GetButtonDown(ControllerButton.DPadUp) && controllerInput.GetButton(ControllerButton.B))
                slider3.value = slider3.value - (sliceSpeed * Time.deltaTime);        
        }

        //Slice from buttom to top
        if (slider4 != null)
        {   
            if(controllerInput.GetButtonDown(ControllerButton.DPadLeft) && controllerInput.GetButton(ControllerButton.B))
                slider4.value = slider4.value - (sliceSpeed * Time.deltaTime);
            if (controllerInput.GetButtonDown(ControllerButton.DPadRight) && controllerInput.GetButton(ControllerButton.B))
                slider4.value = slider4.value + (sliceSpeed * Time.deltaTime);
        }

        //Slice from left/right
        if (slider5 != null)
        {
            if(controllerInput.GetButtonDown(ControllerButton.DPadDown) && controllerInput.GetButton(ControllerButton.X))
                slider5.value = slider5.value + (sliceSpeed * Time.deltaTime);
            if (controllerInput.GetButtonDown(ControllerButton.DPadUp) && controllerInput.GetButton(ControllerButton.X))
                slider5.value = slider5.value - (sliceSpeed * Time.deltaTime);
        }

        //Slice from right/left
        if (slider6 != null)
        {
            if(controllerInput.GetButtonDown(ControllerButton.DPadLeft) && controllerInput.GetButton(ControllerButton.X))
                slider6.value = slider6.value - (sliceSpeed * Time.deltaTime);
            if (controllerInput.GetButtonDown(ControllerButton.DPadRight) && controllerInput.GetButton(ControllerButton.X))
                slider6.value = slider6.value + (sliceSpeed * Time.deltaTime);
        }

        //Change stretchpower value
        if(stretchpower != null)
        {
            if (controllerInput.GetButton(ControllerButton.DPadDown) && controllerInput.GetButton(ControllerButton.Y))
                stretchpower.value = stretchpower.value - (stretchspeed * Time.deltaTime);
            if (controllerInput.GetButton(ControllerButton.DPadUp) && controllerInput.GetButton(ControllerButton.Y))
                stretchpower.value = stretchpower.value + (stretchspeed * Time.deltaTime);
        }

    }

    //Rotation speed
    public float RotateAroundYSpeed = 3.0f;
    public float RotateAroundXSpeed = 3.0f;
    public float RotateAroundZSpeed = 3.0f;

    //Movement speed
    public float MoveHorizontalSpeed = 2.0f;
    public float MoveVerticalSpeed = 2.0f;

    //Zoom speed
    public float ScaleSpeed = 0.1f;

    public void translateRotateScale()
    {
        //Moving the Object with the left stick
        float moveHorizontal = MoveHorizontalSpeed * controllerInput.GetAxisLeftThumbstickX(); 
        float moveVertical = MoveVerticalSpeed * controllerInput.GetAxisLeftThumbstickY(); 
        this.transform.Translate(moveHorizontal, moveVertical, 0.0f);

        //Rotate the Object with the Left and Right Shoulder Buttons, clockwise and counterclockwise
        float rotateAroundY = RotateAroundYSpeed *  (controllerInput.GetAxisRightTrigger() - controllerInput.GetAxisLeftTrigger());

        //Rotate the Object with right stick
        float rotateAroundX = RotateAroundXSpeed * controllerInput.GetAxisRightThumbstickY(); 
        float rotateAroundZ = RotateAroundZSpeed * controllerInput.GetAxisRightThumbstickX();
        this.transform.Rotate(rotateAroundX, -rotateAroundY, rotateAroundZ); 

        
        //Zoom+
        if (controllerInput.GetButton(ControllerButton.RightShoulder)) 
            this.transform.localScale = this.transform.localScale + (this.transform.localScale * ScaleSpeed * Time.deltaTime);

        //Zoom-
        if (controllerInput.GetButton(ControllerButton.LeftShoulder))
            this.transform.localScale = this.transform.localScale - (this.transform.localScale * ScaleSpeed * Time.deltaTime);
    }

    /*how to trigger Button input
        GetAxis         Trigger for Axis
        GetButton       Triggers effect while holding the button
        GetButtonDown   Triggers effect every time the button gets pushed
        GetButtonUp     Triggers effect every time the button gets relesed
    */ 
}
