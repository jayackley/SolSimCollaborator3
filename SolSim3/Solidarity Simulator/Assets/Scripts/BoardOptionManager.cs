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
    AudioSource sound;
    public float Volume;
    public AudioClip swap;



    void Start()
    {
        currentSelect = 1;
        optionOne.SetActive(false);
        optionTwo.SetActive(false);
        numberOfOptions = 2;
        sound = GetComponent<AudioSource>();
    }

    private void Update()
    {

        if (boardPanel.GetComponent<NegotiationDialogueManager>().index == 1 || boardPanel.GetComponent<NegotiationDialogueManager>().index == 5 || boardPanel.GetComponent<NegotiationDialogueManager>().index == 11 || boardPanel.GetComponent<NegotiationDialogueManager>().index == 21 || boardPanel.GetComponent<NegotiationDialogueManager>().index == 29 || boardPanel.GetComponent<NegotiationDialogueManager>().index == 36 || boardPanel.GetComponent<NegotiationDialogueManager>().index == 39 || boardPanel.GetComponent<NegotiationDialogueManager>().index == 44)
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
            sound.PlayOneShot(swap, Volume);
        }

        else if (numberOfOptions == 2 && (Event.current.Equals(Event.KeyboardEvent("down")) || (Event.current.Equals(Event.KeyboardEvent("s")))) && currentSelect == 2)
        {
            currentSelect = 1;
            sound.PlayOneShot(swap, Volume);
        }

        else if (numberOfOptions == 2 && (Event.current.Equals(Event.KeyboardEvent("up")) || (Event.current.Equals(Event.KeyboardEvent("w")))) && currentSelect == 1)
        {
            currentSelect = 2;
            sound.PlayOneShot(swap, Volume);
        }

        else if (numberOfOptions == 2 && (Event.current.Equals(Event.KeyboardEvent("up")) || (Event.current.Equals(Event.KeyboardEvent("w")))) && currentSelect == 2)
        {
            currentSelect = 1;
            sound.PlayOneShot(swap, Volume);
        }

        else if (numberOfOptions == 0 && boardPanel.GetComponent<NegotiationDialogueManager>().isTyping == false)
        {
            primed = true;
        }
    }
}
