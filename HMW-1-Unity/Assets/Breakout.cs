using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Breakout : MonoBehaviour
{
    public InputActionReference action;
    private bool isOutside = false;

    void Update()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (isOutside)
                {transform.position= new Vector3(0,0,0);}
            else
                {
                  transform.position= new Vector3(20,0,1);
                }
            isOutside =!isOutside;
        };
    }   
}

    

