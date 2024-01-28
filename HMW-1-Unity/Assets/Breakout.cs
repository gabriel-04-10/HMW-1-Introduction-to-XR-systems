using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionSwitcher : MonoBehaviour
{
    public Transform externalViewPoint;
    public Transform roomPosition;

    private bool isInExternalView = false;

    void Start()
    {
        isInExternalView = false;
        SwitchToRoomPosition();
    }


    void Update()
    {
    if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (isInExternalView)
            {
                SwitchToRoomPosition();
            }
            else
            {
                SwitchToExternalViewPoint();
            }
        }
    }


    void SwitchToRoomPosition()
    {
        Debug.Log("Switching to Room Position");
        if (roomPosition != null)
        {
            transform.SetPositionAndRotation(roomPosition.position, roomPosition.rotation);
            isInExternalView = false;
        }
    }

    void SwitchToExternalViewPoint()
    {
        Debug.Log("Switching to External View Point");
        if (externalViewPoint != null)
        {
            transform.SetPositionAndRotation(externalViewPoint.position, externalViewPoint.rotation);
            isInExternalView = true;
        }
    }

}

