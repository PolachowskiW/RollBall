using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MazeControls : MonoBehaviour
{
    //Sensitivity value set as default at the start of the game
    public static float SensitivityX = 2f;
    public static float SensitivityZ = 2f;

    //value regulating rotation speed of the maze
    float speed;


    private void Start()
    {
       //At the start of the game this instruction makes sure that maze rotation is set to 0 in all 3 axis
       transform.rotation = Quaternion.identity;
    }

    void Update()
    {
        //rotation speed is regulated based on wether UI different than in-game one is active
        if (UIManager.GamePaused)
        {
            speed = 0f;
        }
        else if (UIManager.SetsOn)
        {
            speed = 0f;
        }
        else if (UIManager.WinAchieved)
        {
            speed = 0f;
        }
        else
        {
            speed = 1.5f;
        }
       
        //functions used to rotate maze
        XRotation();
        ZRotation();
    }

    //Function rotating the maze in local X axis of the device. Because game is played in horizontal mode, global Y axis is translated to local X axis
    public void XRotation()
    {
        //set of conditions regulating when the maze will be rotated, based on accelerometer read and sensitivity set, and limiting rotation angles of the maze so players can navigate it with ease
        if ((Input.acceleration.y > SensitivityX/10) && ((transform.rotation.eulerAngles.x < 20) || (transform.rotation.eulerAngles.x > 335)))
        {
            transform.Rotate(speed, 0, 0);
        }
        //To rotate maze in the same axis but opposite direction, conditions are reversed compared to conditions above
        else if ((Input.acceleration.y < -SensitivityX/10) && ((transform.rotation.eulerAngles.x > 340) || (transform.rotation.eulerAngles.x < 25)))
        {
            transform.Rotate(-speed, 0, 0);
        }

        //if input reads are below sensitivity settings or maze reached rotation limit, it will not rotate anymore
        else
        {
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
        }
    }

    //Function rotating the maze in local Z axis of the device. Because game is played in horizontal mode, global X axis is translated to local Z axis
    public void ZRotation()
    {
       //Set of conditions identical to conditions for local X axis with different global axis input (global X axis)
        if ((Input.acceleration.x < -SensitivityZ/10) && ((transform.rotation.eulerAngles.z < 20) || (transform.rotation.eulerAngles.z > 335)))
        {
            transform.Rotate(0, 0, speed);
        }

        else if ((Input.acceleration.x > SensitivityZ/10) && ((transform.rotation.eulerAngles.z > 340) || (transform.rotation.eulerAngles.z < 25)))
        {
            transform.Rotate(0, 0, -speed);
        }
        else
        {
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
        }

    }

    //Dynamic float function adjusting sensitivity for each axis
    //function arguments take information from sensitivity sliders in Settings UI
    public void SetSensX(float newSensX)
    {
        //instruction overwritting current sensitivity setting with input from sensitivity slider
        SensitivityX = newSensX;
        Debug.Log("Sens X set to" + SensitivityX);
    }

    //Function and set of instructions identical to function above allowing to change sensitivity for local Z axis independently
    public void SetSensZ(float newSensZ)
    {
        SensitivityZ = newSensZ;
        Debug.Log("Sens X set to" + SensitivityZ);
    }

}
