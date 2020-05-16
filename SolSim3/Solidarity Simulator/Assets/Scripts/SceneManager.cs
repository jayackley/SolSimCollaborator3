using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SceneManager : MonoBehaviour {

    public GameObject uiCanvas;
    public int convoCounter;
    public GameObject playerObject;
    public GameObject playerBoard;
    public GameObject playerFactory;
    public GameObject wrench;
    public GameObject wrenchBoard;
    public GameObject wrenchFactory;
    public GameObject temp;
    public GameObject tempBoard;
    public GameObject tempFactory;
    public GameObject welder;
    public GameObject welderBoard;
    public GameObject bigGuy;
    public GameObject bigGuyBoard;
    public GameObject bigGuyFactory;
    public GameObject data;
    public GameObject dataBoard;
    public GameObject accounting;
    public GameObject accountingBoard;
    public GameObject accountingFactory;
    public GameObject manager;
    public GameObject managerBoard;
    public GameObject managerFactory;
    public GameObject corporate;
    public GameObject corporateFactory;
    public GameObject mainCamera;
    public GameObject perspectiveCamera;
    public GameObject promptPanel;
    public GameObject walkaroundOptionManager;
    public GameObject boardPanel;
    public GameObject negotiationDialogueManager;
    public GameObject boardOptionManager;
    public GameObject solidarityPanel;
    public GameObject solidarityObject;
    public GameObject blackOutObject;
    public GameObject uiPressCircle;
    public GameObject optionManager;


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
            solidarityObject.GetComponent<SolidarityManager>().solidarity = 100;
        }
        if (Event.current.Equals(Event.KeyboardEvent("n")))
        {
            convoCounter = 12;
        }
        if (Event.current.Equals(Event.KeyboardEvent("e")))
        {
            convoCounter = 14;
        }
        if (Event.current.Equals(Event.KeyboardEvent("return"))&& convoCounter == 9 && blackOutObject.GetComponent<BlackOutManager>().isTyping == false)
        {
            convoCounter = 10;
        }
        if (Event.current.Equals(Event.KeyboardEvent("return")) && convoCounter == 16 && blackOutObject.GetComponent<BlackOutManager>().isTyping == false)
        {
            convoCounter = 17;
        }
    }

    void Update()
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
            solidarityPanel.transform.localPosition = new Vector3(250, -235, 0);
            uiPressCircle.transform.localPosition = new Vector3(318, -178, 0);
            mainCamera.GetComponent<CinemachineBrain>().m_DefaultBlend.m_Time = 1;
            blackOutObject.SetActive(true);
            blackOutObject.GetComponent<BlackOutManager>().NextSentence();
            uiPressCircle.SetActive(true);
            mainCamera.GetComponent<CameraManager>().scene = "board";
            walkaroundOptionManager.SetActive(false);

            convoCounter = 9;
        }
        if (convoCounter == 10)
        {
            boardPanel.SetActive(true);
            boardPanel.GetComponent<BoardManager>().NextSentence();
            blackOutObject.SetActive(false);
            playerObject.transform.position = playerBoard.transform.position;
            playerObject.GetComponent<InteractionManager>().enabled = false;
            uiPressCircle.transform.localPosition = new Vector3(203, 104, 0);
            convoCounter = 11;
        }
        if (convoCounter == 12)
        {
            uiCanvas.GetComponent<Canvas>().enabled = true;
            promptPanel.SetActive(false);
            optionManager.SetActive(false);
            negotiationDialogueManager.SetActive(true);
            boardOptionManager.SetActive(true);
            negotiationDialogueManager.GetComponent<NegotiationDialogueManager>().index = 50;
            negotiationDialogueManager.GetComponent<NegotiationDialogueManager>().NextSentence();

            temp.transform.position = tempFactory.transform.position;
            temp.GetComponent<CapsuleCollider2D>().enabled = true;
            temp.GetComponent<SpriteRenderer>().flipX = false;
            temp.GetComponent<SpriteRenderer>().sortingOrder = 0;

            welder.GetComponent<CapsuleCollider2D>().enabled = true;
            welder.GetComponent<SpriteRenderer>().flipX = false;
            welder.GetComponent<Animator>().SetTrigger("atfactory");

            bigGuy.transform.position = bigGuyFactory.transform.position;
            bigGuy.GetComponent<CapsuleCollider2D>().enabled = false;

            data.GetComponent<CapsuleCollider2D>().enabled = true;
            data.GetComponent<Animator>().enabled = true;

            accounting.transform.position = accountingFactory.transform.position;
            accounting.GetComponent<CapsuleCollider2D>().enabled = true;
            accounting.GetComponent<SpriteRenderer>().flipX = false;

            manager.transform.position = managerFactory.transform.position;
            manager.GetComponent<CapsuleCollider2D>().enabled = true;
            manager.GetComponent<ManagerOutfit>().wearing = "office";

            corporate.transform.position = corporateFactory.transform.position;
            solidarityPanel.transform.localPosition = new Vector3(250, -235, 0);
            solidarityObject.GetComponent<SolidarityManager>().leverage = true;
            mainCamera.GetComponent<CameraManager>().scene = "negotiate";
        }
        if (convoCounter == 13)
        {
            uiPressCircle.transform.localPosition = new Vector3(-34, 54, 0);
        }

        if (convoCounter == 14)
        {
            negotiationDialogueManager.SetActive(false);
            mainCamera.GetComponent<CameraManager>().whosFocus = "pc";
            mainCamera.GetComponent<CameraManager>().scene = "walkaround";
            playerObject.transform.position = playerFactory.transform.position;
            wrench.transform.position = wrenchFactory.transform.position;
            playerObject.GetComponent<SpriteRenderer>().flipX = false;
            playerObject.GetComponent<MovementController>().enabled = false;
            wrench.GetComponent<CapsuleCollider2D>().enabled = true;
            wrench.GetComponent<SpriteRenderer>().flipX = false;
            wrench.GetComponent<SpriteRenderer>().sortingOrder = 0;
            solidarityObject.SetActive(false);
            blackOutObject.SetActive(true);
            blackOutObject.GetComponent<BlackOutManager>().index += 1;
            blackOutObject.GetComponent<BlackOutManager>().NextSentence();
            convoCounter = 15;
            uiPressCircle.SetActive(false);
            boardOptionManager.SetActive(false);

        }
        if (convoCounter == 17)
        {
            uiCanvas.GetComponent<Canvas>().enabled = false;
            promptPanel.SetActive(true);
            solidarityPanel.SetActive(false);
            optionManager.SetActive(true);
            playerObject.GetComponent<MovementController>().enabled = true;
            blackOutObject.SetActive(false);
            //change something for the interaction manager so that prompt panels go to different index numbers
        }

    }
}
