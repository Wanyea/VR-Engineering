using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithPlayer : MonoBehaviour
{
    public GameObject greeterBot;
    [HideInInspector] public bool isPlayerInLab = false;
    private Vector3 greeterBotEndPosition;

    void Start() 
    {
        greeterBotEndPosition = new Vector3(
                greeterBot.transform.position.x,
                greeterBot.transform.position.y,
                greeterBot.transform.position.z - 5);
    }

    void Update() 
    {
        if (isPlayerInLab) 
        {
            greeterBot.transform.position = Vector3.Lerp(greeterBot.transform.position, greeterBotEndPosition);
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player")) 
        {
            isPlayerInLab = true; 
        }
    }
}
