using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliceAxis1Min : MonoBehaviour
{

    Renderer thisRend; 
    public Slider mainSlider;

    void Start()
    {
        thisRend = GetComponent<Renderer>();
         
    }

    void Update()
    {
        thisRend.material.SetFloat("_SliceAxis1Min", mainSlider.value);
    }
}