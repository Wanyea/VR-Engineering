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
        transform.position = new Vector3(defaultPosition.x, defaultPosition.y, transform.position.z);
        transform.rotation = Quaternion.identity;
    }


}
