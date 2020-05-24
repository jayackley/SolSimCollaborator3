using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NegotationSceneManager : MonoBehaviour 

{

    public bool facingCamera;
    public GameObject wrenchNegotiate;
    public GameObject orbNegotiate;
    public GameObject negotiationPanel;


    public void Update()
    {
        if (facingCamera == false)
        {
            wrenchNegotiate.GetComponent<Animator>().SetBool("LookAway", true);
            wrenchNegotiate.GetComponent<Animator>().SetBool("CameraTalking", false);
            wrenchNegotiate.GetComponent<Animator>().SetBool("CameraIdle", false);
        }

        if(facingCamera == true && negotiationPanel.GetComponent<NegotiationDialogueManager>().isTyping == false)
        {
            wrenchNegotiate.GetComponent<Animator>().SetBool("CameraTalking", false);
            wrenchNegotiate.GetComponent<Animator>().SetBool("CameraIdle", true);
            wrenchNegotiate.GetComponent<Animator>().SetBool("LookAway", false);
        }

        if (facingCamera == true && negotiationPanel.GetComponent<NegotiationDialogueManager>().whosTalking == "wrench" && negotiationPanel.GetComponent<NegotiationDialogueManager>().isTyping == true){
            wrenchNegotiate.GetComponent<Animator>().SetBool("LookAway", false);
            wrenchNegotiate.GetComponent<Animator>().SetBool("CameraTalking", true);
            wrenchNegotiate.GetComponent<Animator>().SetBool("CameraIdle", false);

        }
    }
}

