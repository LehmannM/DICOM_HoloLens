using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataTresholdMax : MonoBehaviour
{

    Renderer thisRend;
    public Slider mainSlider;

    void Start()
    {
        thisRend = GetComponent<Renderer>();
    }

    void Update()
    {
        thisRend.material.SetFloat("_DataMax", mainSlider.value);
    }
}