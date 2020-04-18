using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SceneManager : MonoBehaviour {

    public GameObject uiCanvas;
    public int convoCounter;
    public GameObject playerObject;
    public GameObject playerBoard;
    public GameObject wrench;
    public GameObject wrenchBoard;
    public GameObject temp;
    public GameObject tempBoard;
    public GameObject welder;
    public GameObject welderBoard;
    public GameObject bigGuy;
    public GameObject bigGuyBoard;
    public GameObject data;
    public GameObject dataBoard;
    public GameObject accounting;
    public GameObject accountingBoard;
    public GameObject manager;
    public GameObject managerBoard;
    public GameObject mainCamera;
    public GameObject perspectiveCamera;
    public GameObject promptPanel;
    public GameObject boardPanel;
    public GameObject solidarityPanel;
    public GameObject blackOutObject;
    public GameObject uiPressCircle;


    void Start()
    {
        uiCanvas.GetComponent<Canvas>().enabled = false;
        foreach (GameObject floor in GameObject.FindGameObjectsWithTag("Floor"))
        {
            floor.GetComponent<SpriteRenderer>().enabled = false;
        }
        foreach (GameObject floor in GameObject.FindGameObjectsWithTag("Diagonal"))
        {
            floor.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    private void OnGUI()
    {
        if (Event.current.Equals(Event.KeyboardEvent("b")))
        {
            convoCounter = 8;
        }
        if (Event.current.Equals(Event.KeyboardEvent("return"))&& convoCounter == 9 && blackOutObject.GetComponent<BlackOutManager>().isTyping == false)
        {
            convoCounter = 10;
        }
    }

    void Update () 
    {
        if (convoCounter == 8)
        {

            playerObject.GetComponent<SpriteRenderer>().flipX = true;
            playerObject.GetComponent<MovementController>().canPoke = false;

            wrench.transform.position = wrenchBoard.transform.position;
            wrench.GetComponent<CapsuleCollider2D>().enabled = false;
            wrench.GetComponent<SpriteRenderer>().flipX = true;
            wrench.GetComponent<SpriteRenderer>().sortingOrder = 2;

            temp.transform.position = tempBoard.transform.position;
            temp.GetComponent<CapsuleCollider2D>().enabled = false;
            temp.GetComponent<SpriteRenderer>().flipX = true;
            temp.GetComponent<SpriteRenderer>().sortingOrder = 2;

            welder.transform.position = welderBoard.transform.position;
            welder.GetComponent<CapsuleCollider2D>().enabled = false;
            welder.GetComponent<SpriteRenderer>().flipX = true;
            welder.GetComponent<Animator>().SetTrigger("atboard");

            bigGuy.transform.position = bigGuyBoard.transform.position;
            bigGuy.GetComponent<CapsuleCollider2D>().enabled = false;

            data.transform.position = dataBoard.transform.position;
            data.GetComponent<CapsuleCollider2D>().enabled = false;
            data.GetComponent<Animator>().enabled = false;

            accounting.transform.position = accountingBoard.transform.position;
            accounting.GetComponent<CapsuleCollider2D>().enabled = false;
            accounting.GetComponent<SpriteRenderer>().flipX = true;

            manager.transform.position = managerBoard.transform.position;
            manager.GetComponent<CapsuleCollider2D>().enabled = false;
            manager.GetComponent<ManagerOutfit>().wearing = "meeting";


            mainCamera.GetComponent<CameraManager>().whosFocus = "corporate";
            uiCanvas.GetComponent<Canvas>().enabled = true;
            promptPanel.SetActive(false);
            solidarityPanel.transform.localPosition = new Vector3(250, -245, 0);
            uiPressCircle.transform.localPosition = new Vector3(-280, -230, 0);
            mainCamera.GetComponent<CinemachineBrain>().m_DefaultBlend.m_Time = 1;
            blackOutObject.SetActive(true);
            blackOutObject.GetComponent<BlackOutManager>().NextSentence();
            uiPressCircle.SetActive(true);
            mainCamera.GetComponent<CameraManager>().scene = "board";

            convoCounter = 9;
        }
        if (convoCounter == 10)
        {
            boardPanel.SetActive(true);
            boardPanel.GetComponent<BoardManager>().NextSentence();
            blackOutObject.SetActive(false);
            playerObject.transform.position = playerBoard.transform.position;
            playerObject.GetComponent<InteractionManager>().enabled = false;
            convoCounter = 11;
        }
        if (convoCounter == 12)
        {
            //set up for board
        }
    }
}
