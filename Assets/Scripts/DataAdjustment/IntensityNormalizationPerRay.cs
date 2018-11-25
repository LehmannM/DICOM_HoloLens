﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntensityNormalizationPerRay : MonoBehaviour
{
    Renderer thisRend1;
    public Slider mainSlider;

    void Start()
    {
        thisRend1 = GetComponent<Renderer>();
    }

    void Update()
    {
        thisRend1.material.SetFloat("_NormPerRay", mainSlider.value);
    }
}

