using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;

    void Start()
    {
       //instructions setting main camera as an active
       cam1.enabled = true;
       cam2.enabled = false;
       cam3.enabled = false;
    }

    public void switchcam(int x)
    {
        deactivateall();
        //set of conditions enabling cameras assigned to proper buttons
        //if one camera is active, others will be deactivated
        if (x == 1)
        {
            cam1.enabled = true;
            cam2.enabled = false;
            cam3.enabled = false;
        }
        else if (x == 2)
        {
            cam2.enabled = true;
            cam1.enabled = false;
            cam3.enabled = false;
        }
        else if (x == 3)
        {
            cam3.enabled = true;
            cam1.enabled = false;
            cam2.enabled = false;

        }
    }

    public void deactivateall()
    {
        cam1.enabled = false;
        cam2.enabled = false;
        cam3.enabled = false;
    }
}
