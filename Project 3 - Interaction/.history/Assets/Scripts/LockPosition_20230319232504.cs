using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPosition : MonoBehaviour
{
    public Vector3 defaultPosition;
    public Vector3 defaultRotation;

    void Awake() 
    {
        defaultPosition = transform.position;
        defaultRotation = transform.eulerAngles;
    }

    void LateUpdate() 
    {
        transform.position = new Vector3(defaultPosition.x, defaultPosition.y, transform.position.z);
        transform.eulerAngles = defaultRotation;
    }


}
