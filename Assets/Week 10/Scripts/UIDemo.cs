using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIDemo : MonoBehaviour
{
    public SpriteRenderer sr;
    public Color start;
    public Color end;
    float interpolation;
    public TMP_Dropdown dropdown;

    public void SliderValueHasChanged(Single value)
    {
        interpolation = value;
    }

    private void Update()
    {
        sr.color = Color.Lerp(start, end, interpolation/60);
    }

    public void DropdownHasChanged(Int32 value)
    {
        Debug.Log(dropdown.options[value].text);
    }
}
