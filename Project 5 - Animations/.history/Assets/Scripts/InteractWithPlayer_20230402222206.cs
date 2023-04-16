using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithPlayer : MonoBehaviour
{
    public GameObject greeterBot;
    [HideInInspector] public bool isRobotMoving = false;
    private Vector3 greeterBotEndPosition;
    private Animator greeterBotAnimator;

    void Start() 
    {
        greeterBotAnimator = greeterBot.GetComponent<Animator>();
        greeterBotEndPosition = new Vector3(
                greeterBot.transform.position.x,
                greeterBot.transform.position.y,
                greeterBot.transform.position.z - 5);
    }

    void Update() 
    {
        if (isRobotMoving) 
        {
            greeterBot.transform.position = Vector3.Lerp(greeterBot.transform.position, greeterBotEndPosition, 3.0f);

            if (greeterBot.transform.position == greeterBotEndPosition) 
            {
                
                isRobotMoving = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player")) 
        {
            isRobotMoving = true; 
        }
    }
}
