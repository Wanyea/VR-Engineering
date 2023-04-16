using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPosition : MonoBehaviour
{
    public Vector3 defaultPosition;

    void Awake() 
    {
        defaultPosition = transform.position;
    }

    void LateUpdate() 
    {
        transform.position = new Vector3(defaultPostion.x, defaultPosition.y, defaultPosition)defaultPosition.x;
        transform.position = defaultPosition.y;
        transform.rotation = Quaternion.identity;
    }


}
