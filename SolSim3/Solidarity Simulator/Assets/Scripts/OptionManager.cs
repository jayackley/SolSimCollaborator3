using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionManager : MonoBehaviour
{

    public int sentenceIndex;
    public int currentSelect;
    public GameObject optionOne;
    public GameObject optionTwo;
    public GameObject optionThree;
    public GameObject promptPanel;
    public GameObject solidarityObject;
    public GameObject playerObject;
    public GameObject uiCanvas;
    public int numberOfOptions;
    public GameObject sceneManager;
    public GameObject mainCamera;
    public GameObject uiPressCircle;
    public GameObject buttonInstruction;
    public bool primed;
    

    void Start()
    {
        currentSelect = 1;
        optionOne.SetActive(false);
        optionTwo.SetActive(false);
        optionThree.SetActive(false);
        numberOfOptions = 3;
    }

    private void Update()
    {
        if (sentenceIndex == 0 || sentenceIndex == 1 || sentenceIndex == 11 || sentenceIndex == 12 || sentenceIndex == 13 || sentenceIndex == 22 || sentenceIndex == 36 || sentenceIndex == 42 || sentenceIndex == 52)
        {
            numberOfOptions = 3;
        }

        else if (sentenceIndex == 2 || sentenceIndex == 3 || sentenceIndex == 21 || sentenceIndex == 23 || sentenceIndex == 29 || sentenceIndex == 30 || sentenceIndex == 31 || sentenceIndex == 37 || sentenceIndex == 43 || sentenceIndex == 44 || sentenceIndex == 45 || sentenceIndex == 53 || sentenceIndex == 54)
        {
            numberOfOptions = 2;
        }

        else if ((sentenceIndex >= 4 && sentenceIndex <= 10) || (sentenceIndex >= 14 && sentenceIndex <= 20) || (sentenceIndex >= 24 && sentenceIndex <= 28) || (sentenceIndex >= 32 && sentenceIndex <= 35) || (sentenceIndex >= 38 && sentenceIndex <= 41) || (sentenceIndex >= 46 && sentenceIndex <= 51) || (sentenceIndex >= 55 && sentenceIndex <= 59))
        {
            numberOfOptions = 0;
        }

        //if two options

        if (numberOfOptions == 2 && currentSelect == 1 && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            optionOne.SetActive(true);
            optionTwo.SetActive(true);
            optionOne.GetComponent<Image>().color = UnityEngine.Color.blue;
            optionTwo.GetComponent<Image>().color = UnityEngine.Color.black;
        }

        else if (numberOfOptions == 2 && currentSelect == 2 && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            optionOne.SetActive(true);
            optionTwo.SetActive(true);
            optionOne.GetComponent<Image>().color = UnityEngine.Color.black;
            optionTwo.GetComponent<Image>().color = UnityEngine.Color.blue;
        }

        //if three options

        else if (numberOfOptions == 3 && currentSelect == 1 && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            optionOne.SetActive(true);
            optionTwo.SetActive(true);
            optionThree.SetActive(true);
            optionOne.GetComponent<Image>().color = UnityEngine.Color.blue;
            optionTwo.GetComponent<Image>().color = UnityEngine.Color.black;
            optionThree.GetComponent<Image>().color = UnityEngine.Color.black;

        }
        else if (numberOfOptions == 3 && currentSelect == 2 && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            optionOne.SetActive(true);
            optionTwo.SetActive(true);
            optionThree.SetActive(true);
            optionOne.GetComponent<Image>().color = UnityEngine.Color.black;
            optionTwo.GetComponent<Image>().color = UnityEngine.Color.blue;
            optionThree.GetComponent<Image>().color = UnityEngine.Color.black;

        }
        else if (numberOfOptions == 3 && currentSelect == 3 && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            optionOne.SetActive(true);
            optionTwo.SetActive(true);
            optionThree.SetActive(true);
            optionOne.GetComponent<Image>().color = UnityEngine.Color.black;
            optionTwo.GetComponent<Image>().color = UnityEngine.Color.black;
            optionThree.GetComponent<Image>().color = UnityEngine.Color.blue;

        }

        else
        {
            optionOne.SetActive(false);
            optionTwo.SetActive(false);
            optionThree.SetActive(false);

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

        //If 3 options

        else if ((Event.current.Equals(Event.KeyboardEvent("down")) || (Event.current.Equals(Event.KeyboardEvent("s")))) && currentSelect == 1)
        {
            currentSelect = 2;
        }
        else if ((Event.current.Equals(Event.KeyboardEvent("down")) || (Event.current.Equals(Event.KeyboardEvent("s")))) && currentSelect == 2)
        {
            currentSelect = 3;
        }
        else if ((Event.current.Equals(Event.KeyboardEvent("down")) || (Event.current.Equals(Event.KeyboardEvent("s")))) && currentSelect == 3)
        {
            currentSelect = 1;
        }
        else if ((Event.current.Equals(Event.KeyboardEvent("up")) || (Event.current.Equals(Event.KeyboardEvent("w")))) && currentSelect == 1)
        {
            currentSelect = 3;
        }
        else if ((Event.current.Equals(Event.KeyboardEvent("up")) || (Event.current.Equals(Event.KeyboardEvent("w")))) && currentSelect == 3)
        {
            currentSelect = 2;
        }
        else if ((Event.current.Equals(Event.KeyboardEvent("up")) || (Event.current.Equals(Event.KeyboardEvent("w")))) && currentSelect == 2)
        {
            currentSelect = 1;
        }

        //Choosing Options
        //wrench

        //sentence index 0
        if ((sentenceIndex == 0 && currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 20;
            sentenceIndex = 1;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 0 && currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return")))&& promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 5;
            sentenceIndex = 2;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 0 && currentSelect == 3 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 30;
            sentenceIndex = 3;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }
        //sentence index 1
        else if ((sentenceIndex == 1 && currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 20;
            sentenceIndex = 4;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 1 && currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 5;
            sentenceIndex = 5;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 1 && currentSelect == 3 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 30;
            sentenceIndex = 6;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }
        //sentence index 2

        else if ((sentenceIndex == 2 && currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 20;
            sentenceIndex = 7;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 2 && currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 5;
            sentenceIndex = 8;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        //sentence index 3

        else if ((sentenceIndex == 3 && currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 20;
            sentenceIndex = 9;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 3 && currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 5;
            sentenceIndex = 10;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        //sentence index 11
        else if ((sentenceIndex == 11 && currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 10;
            sentenceIndex = 12;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 11 && currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 5;
            sentenceIndex = 13;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 11 && currentSelect == 3 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 30;
            sentenceIndex = 20;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        //sentence index 12
        else if ((sentenceIndex == 12 && currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 20;
            sentenceIndex = 14;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 12 && currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 5;
            sentenceIndex = 15;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 12 && currentSelect == 3 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 20;
            sentenceIndex = 16;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        //sentence index 13
        else if ((sentenceIndex == 13 && currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 10;
            sentenceIndex = 17;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 13 && currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 5;
            sentenceIndex = 18;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 13 && currentSelect == 3 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 15;
            sentenceIndex = 19;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        //sentence index 21
        else if ((sentenceIndex == 21 && currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 10;
            sentenceIndex = 22;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 21 && currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 20;
            sentenceIndex = 23;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        //sentence index 22
        else if ((sentenceIndex == 22 && currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 15;
            sentenceIndex = 24;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 22 && currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 5;
            sentenceIndex = 25;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 22 && currentSelect == 3 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 20;
            sentenceIndex = 26;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        //sentence index 23
        else if ((sentenceIndex == 23 && currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 5;
            sentenceIndex = 27;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 23 && currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 15;
            sentenceIndex = 28;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        //sentence index 29
        else if ((sentenceIndex == 29 && currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 10;
            sentenceIndex = 30;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 29 && currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 10;
            sentenceIndex = 31;
            promptPanel.GetComponent<PromptManager>().NextSentence(); 
            currentSelect = 1;
        }

        //sentence index 30
        else if ((sentenceIndex == 30 && currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 10;
            sentenceIndex = 32;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 30 && currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 15;
            sentenceIndex = 33;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        //sentence index 31
        else if ((sentenceIndex == 31 && currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 10;
            sentenceIndex = 34;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 31 && currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 5;
            sentenceIndex = 35;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        //sentence index 36
        else if ((sentenceIndex == 36 && currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 10;
            sentenceIndex = 37;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 36 && currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 5;
            sentenceIndex = 40;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 36 && currentSelect == 3 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 30;
            sentenceIndex = 41;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        //sentence index 37
        else if ((sentenceIndex == 37 && currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 20;
            sentenceIndex = 38;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 37 && currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 5;
            sentenceIndex = 39;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }
        //sentence index 42
        else if ((sentenceIndex == 42 && currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 20;
            sentenceIndex = 43;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 42 && currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 10;
            sentenceIndex = 44;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 42 && currentSelect == 3 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 5;
            sentenceIndex = 45;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        //sentence index 43
        else if ((sentenceIndex == 43 && currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 10;
            sentenceIndex = 46;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 43 && currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 10;
            sentenceIndex = 47;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        //sentence index 44
        else if ((sentenceIndex == 44 && currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 20;
            sentenceIndex = 48;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 44 && currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 30;
            sentenceIndex = 49;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        //sentence index 45
        else if ((sentenceIndex == 45 && currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 5;
            sentenceIndex = 50;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 45 && currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 5;
            sentenceIndex = 51;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        //sentence index 52
        else if ((sentenceIndex == 52 && currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 5;
            sentenceIndex = 53;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 52 && currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 5;
            sentenceIndex = 54;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 52 && currentSelect == 3 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 10;
            sentenceIndex = 59;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        //sentence index 53
        else if ((sentenceIndex == 53 && currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 5;
            sentenceIndex = 55;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 53 && currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 15;
            sentenceIndex = 56;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        //sentence index 54

        else if ((sentenceIndex == 54 && currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity += 5;
            sentenceIndex = 57;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }

        else if ((sentenceIndex == 54 && currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return"))) && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 10;
            sentenceIndex = 58;
            promptPanel.GetComponent<PromptManager>().NextSentence();
            currentSelect = 1;
        }


        //end scene

        else if (Event.current.Equals(Event.KeyboardEvent("return")) && numberOfOptions == 0 && promptPanel.GetComponent<PromptManager>().isTyping == false && sceneManager.GetComponent<SceneManager>().convoCounter == 7)
        {
            playerObject.GetComponent<MovementController>().canPoke = true;
            playerObject.GetComponent<MovementController>().enabled = true;
            playerObject.GetComponent<InteractionManager>().dialogueVisible = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            sceneManager.GetComponent<SceneManager>().convoCounter += 1;
            mainCamera.GetComponent<CameraManager>().whosFocus = "pc";
            primed = false;
            sentenceIndex = 0;
            numberOfOptions = 3;
            playerObject.GetComponent<InteractionManager>().whosTalking = "";
            uiPressCircle.SetActive(false);
            buttonInstruction.SetActive(false);

        }
        else if (Event.current.Equals(Event.KeyboardEvent("return")) && numberOfOptions == 0 && promptPanel.GetComponent<PromptManager>().isTyping == false && sceneManager.GetComponent<SceneManager>().convoCounter < 7)
        {
            playerObject.GetComponent<MovementController>().enabled = true;
            playerObject.GetComponent<InteractionManager>().dialogueVisible = false;
            uiCanvas.GetComponent<Canvas>().enabled = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            playerObject.GetComponent<MovementController>().canPoke = true;
            mainCamera.GetComponent<CameraManager>().whosFocus = "pc";
            primed = false;
            sentenceIndex = 0;
            numberOfOptions = 3;
            playerObject.GetComponent<InteractionManager>().whosTalking = "";
            uiPressCircle.SetActive(false);
            buttonInstruction.SetActive(false);

        }
        else if (numberOfOptions == 0 && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            uiPressCircle.SetActive(true);
            primed = true;
        }
    }
}
