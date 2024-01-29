using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public new Light light;
    public InputActionReference action;
    private bool isBlue = false;
    void Update()
    {
        light = GetComponent<Light>(); 
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (isBlue)
                {
                    light.color = Color.blue;
                }
            else
                {
                  light.color = Color.white;
                }
            isBlue =!isBlue;  
        };
    }
}

