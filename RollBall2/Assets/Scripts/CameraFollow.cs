using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform BallTransform;
    public Transform CamTransform;
    private Vector3 cameraOffset;
    
    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;
    
    void Start()
    {
        cameraOffset = transform.position - BallTransform.position;
    }

    void LateUpdate()
    {
        Vector3 newPos = BallTransform.position + cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
    }
}
