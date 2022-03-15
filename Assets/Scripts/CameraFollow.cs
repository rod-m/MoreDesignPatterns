using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;


    void Start()
    {
        // the offset position of the camera to target
        // the y axis retains current camera y
        offset = new Vector3(
            transform.position.x - target.position.x,
            transform.position.y,
            transform.position.z - target.position.z
        );
        
    }

    void LateUpdate()
    {
        // use target position with offset
        transform.position = new Vector3(
            target.position.x + offset.x,
            offset.y,
            target.position.z + offset.z
        );
    }
}