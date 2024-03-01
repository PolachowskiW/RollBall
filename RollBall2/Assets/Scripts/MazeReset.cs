using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeReset : MonoBehaviour
{
    //function that reorients the maze to it's rotation at the start (0 in each axis)
    public void RotReset()
    {
        transform.rotation = Quaternion.identity;
    }
}
