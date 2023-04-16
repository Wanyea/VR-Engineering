using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
   [SerializeField] private Animator myDoor = null;

   [SerializeField] private bool openTrigger = false;
   [SerializeField] private bool closeTrigger = false;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player")) 
        {
            if (openTrigger) 
            {
                myDoor.Play("glass_door_open", 0, 0.0f);
                myDoor.Play("glass_door_opened", 0, 0.0f);
                
            } else if (closeTrigger) {
                myDoor.Play("glass_door_close", 0, 0.0f);
                myDoor.Play("glass_door_closed", 0, 0.0f);
            }
        }
    }
}
