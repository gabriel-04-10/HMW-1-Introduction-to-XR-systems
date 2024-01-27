using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ChangeLightColor : MonoBehaviour
{
    public Light targetLight;
    public float colorChangeSpeed = 1.0f;

    void Update()
    {
        if (HasOculusXRSubsystem())
        {
            string loadedDeviceName = XRSettings.loadedDeviceName;
            if (loadedDeviceName.Contains("Oculus"))
            {
                float triggerValue = Input.GetAxis("Oculus_CrossPlatform_PrimaryIndexTrigger");
                Color newColor = Color.Lerp(Color.red, Color.blue, triggerValue);
                targetLight.color = Color.Lerp(targetLight.color, newColor, Time.deltaTime * colorChangeSpeed);
            }
        }
    }
    bool HasOculusXRSubsystem()
    {
        var subsystemDescriptors = new List<XRDisplaySubsystemDescriptor>();
        SubsystemManager.GetSubsystemDescriptors(subsystemDescriptors);

        foreach (var descriptor in subsystemDescriptors)
        {
            if (descriptor.id.Contains("Oculus"))
            {
                return true;
            }
        }

        return false;
    }
}

