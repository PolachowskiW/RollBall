using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReset : MonoBehaviour
{
    //value to which player will be moved when function is called
    public float PosY;
    public void playerReset()
    {
        //function transforming player to position in Y axis similar to it's starting Y position to avoid player falling out of the maze while it's being reset
        transform.position = new Vector3(transform.position.x, PosY, transform.position.z);
    }
}
