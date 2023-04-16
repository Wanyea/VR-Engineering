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
        transform.position.x = defaultPosition.x;
        transform.position.y = defaultPosition.y;
        transform.rotation = Quaternion.identity;
    }


}
