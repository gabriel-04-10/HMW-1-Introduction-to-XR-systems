using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public new Light light;
    void Start() {
        light = GetComponent<Light>(); 
        }
}