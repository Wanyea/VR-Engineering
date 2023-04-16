using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractWithPlayer : MonoBehaviour
{
    public GameObject greeterBot;
    public TextMeshPro greeterBotMessage;
    [HideInInspector] public bool isRobotMoving = false;
    [HideInInspector] public bool startWalkAnimation = false;
    public float speed = 0.2f;

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
            greeterBotMessage.color = new Color32(255, 255, 255, 255);

            if(startWalkAnimation) 
            {
                greeterBotAnimator.StopPlayback();
                
                greeterBotAnimator.Play("a_Walking", 0, 0.0f);
                startWalkAnimation = false;
            }
                
            greeterBot.transform.position = Vector3.Lerp(greeterBot.transform.position, greeterBotEndPosition, Time.deltaTime * speed);

            if (greeterBot.transform.position == greeterBotEndPosition) 
            {
                greeterBotAnimator.Play("a_Idle_Happy", 0, 0.0f);
                isRobotMoving = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player")) 
        {
            isRobotMoving = true; 
            startWalkAnimation = true;
        }
    }
}
