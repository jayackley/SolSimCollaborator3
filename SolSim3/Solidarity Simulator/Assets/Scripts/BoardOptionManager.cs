using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BoardOptionManager : MonoBehaviour
{

    public int currentSelect;
    public GameObject optionOne;
    public GameObject optionTwo;
    public GameObject boardPanel;
    public GameObject solidarityObject;
    public GameObject playerObject;
    public GameObject uiCanvas;
    public int numberOfOptions;
    public GameObject sceneManager;
    public GameObject mainCamera;
    public bool primed;
    public GameObject optionOneText;
    public GameObject optionTwoText;
    

    void Start()
    {
        currentSelect = 1;
        optionOne.SetActive(false);
        optionTwo.SetActive(false);
        numberOfOptions = 2;
    }

    private void Update()
    {

        if (boardPanel.GetComponent<NegotiationDialogueManager>().index == 51 || boardPanel.GetComponent<NegotiationDialogueManager>().index == 58 || boardPanel.GetComponent<NegotiationDialogueManager>().index == 64 || boardPanel.GetComponent<NegotiationDialogueManager>().index == 74 || boardPanel.GetComponent<NegotiationDialogueManager>().index == 83 || boardPanel.GetComponent<NegotiationDialogueManager>().index == 92 || boardPanel.GetComponent<NegotiationDialogueManager>().index == 97 || boardPanel.GetComponent<NegotiationDialogueManager>().index == 102)
        {
            numberOfOptions = 2;
            primed = false;
        }

        else 
        {
            numberOfOptions = 0;
            primed = false;
        }

        //if two options

        if (numberOfOptions == 2 && currentSelect == 1 && boardPanel.GetComponent<NegotiationDialogueManager>().isTyping == false)
        {
            optionOne.SetActive(true);
            optionTwo.SetActive(true);
            optionOne.GetComponent<Image>().color = UnityEngine.Color.white;
            optionOneText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(0, 255, 128, 255);
            optionTwo.GetComponent<Image>().color = UnityEngine.Color.blue;
            optionTwoText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(0, 255, 128, 60);
            primed = false;
        }

        else if (numberOfOptions == 2 && currentSelect == 2 && boardPanel.GetComponent<NegotiationDialogueManager>().isTyping == false)
        {
            optionOne.SetActive(true);
            optionTwo.SetActive(true);
            optionOne.GetComponent<Image>().color = UnityEngine.Color.blue;
            optionOneText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(0, 255, 128, 60);
            optionTwo.GetComponent<Image>().color = UnityEngine.Color.white;
            optionTwoText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(0, 255, 128, 255);
            primed = false;
        }

        else
        {
            optionOne.SetActive(false);
            optionTwo.SetActive(false);

        }
    }

    private void OnGUI()
    {
        //Moving Between Options

        //if 2 options
        if (numberOfOptions == 2 && (Event.current.Equals(Event.KeyboardEvent("down")) || (Event.current.Equals(Event.KeyboardEvent("s")))) && currentSelect == 1)
        {
            currentSelect = 2;
        }

        else if (numberOfOptions == 2 && (Event.current.Equals(Event.KeyboardEvent("down")) || (Event.current.Equals(Event.KeyboardEvent("s")))) && currentSelect == 2)
        {
            currentSelect = 1;
        }

        else if (numberOfOptions == 2 && (Event.current.Equals(Event.KeyboardEvent("up")) || (Event.current.Equals(Event.KeyboardEvent("w")))) && currentSelect == 1)
        {
            currentSelect = 2;
        }

        else if (numberOfOptions == 2 && (Event.current.Equals(Event.KeyboardEvent("up")) || (Event.current.Equals(Event.KeyboardEvent("w")))) && currentSelect == 2)
        {
            currentSelect = 1;
        }

        else if (numberOfOptions == 0 && boardPanel.GetComponent<NegotiationDialogueManager>().isTyping == false)
        {
            primed = true;
        }
    }
}
