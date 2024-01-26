using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Breakout : MonoBehaviour
{
    private bool position;

    void Start()
    {
        position = (bool)GetPositionAndRotation();
    }

    private object GetPositionAndRotation()
    {
        throw new NotImplementedException();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (position Equals(Vector3.zero));
            {
                transform.position = (30, 7, 5);
            }
        else
            {
                transform.position = Vector3.zero;
            }
        }
    }
}
