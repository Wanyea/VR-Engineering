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
    }


}
