using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
   [SerializeField] private Animator myDoor = null;

   [SerializeField] private bool openTrigger = false;
   [SerializeField] private bool closeTrigger = false;

    private private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player")) 
        {
            if(openTrigger) 
            {
                
            }
        }
    }
}
