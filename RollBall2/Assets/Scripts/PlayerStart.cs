using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStart : MonoBehaviour
{
    public static Vector3 StartPos;
    
    //This function sets player at it's starting position to make sure level resets properly after completion
    void Start()
    {
        StartPos = transform.position;
    }
}
