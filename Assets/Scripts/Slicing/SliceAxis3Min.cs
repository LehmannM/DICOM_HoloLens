using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliceAxis3Min : MonoBehaviour
{

    Renderer thisRend; 
    public Slider mainSlider;
   
    void Start()
    {
        thisRend = GetComponent<Renderer>(); 

    }

    void Update()
    {
        thisRend.material.SetFloat("_SliceAxis3Min", mainSlider.value);
    }
}
