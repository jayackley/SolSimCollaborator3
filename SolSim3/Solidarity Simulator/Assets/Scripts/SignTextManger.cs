using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SignTextManger : MonoBehaviour
{

    public GameObject buttonInstructionText;
    public TextMeshProUGUI buttonTextDisplay;
    public GameObject safetyInstructionText;
    public TextMeshProUGUI safetyTextDisplay;
    public GameObject loremIpsum;
    public GameObject loremIpsum2;
    public GameObject loremIpsum3;
    public GameObject buttonObject;
    public float buttonTypingSpeed;
    public int buttonIndex;
    public string[] buttonSentences;
    public float safetyTypingSpeed;
    public float waitBetweenSafetyMessages;
    public int safetyIndex;
    public string[] safetySentences;
    public bool isTyping;
    public float pauseTime;
    private int nextMessageCounter;

    void Start()
    {
        buttonInstructionText.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
        buttonInstructionText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 135, 0, 255);
        loremIpsum.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 0, 0, 255);
        loremIpsum2.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 0, 0, 255);
        loremIpsum3.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 0, 0, 255);
        safetyInstructionText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(101, 100, 219, 255);
        SafetyNextSentence();
        waitBetweenSafetyMessages = 1;
    }

    IEnumerator ButtonType()
    {
            isTyping = true;

            foreach (char letter in buttonSentences[buttonIndex])
            {
      

                if (letter == '&')
                {
                    Debug.Log("ampersand!");
                    yield return new WaitForSeconds(pauseTime);
                }

                else if (letter == '.' || letter == '!' || letter == '?' || letter == ';')
                {
                    buttonTextDisplay.text += letter;
    
                    yield return new WaitForSeconds(pauseTime);
                }

                else if (letter == ',')
                {
                    buttonTextDisplay.text += letter;
                 
                    yield return new WaitForSeconds(pauseTime / 2);
                }

                else if (letter == '^')
                {
                    buttonTextDisplay.text += "\n";
            
                    yield return new WaitForSeconds(buttonTypingSpeed);
                }

                else if (letter == '@')
                {
                    isTyping = false;
                    break;
                }

                else if (letter == '{')
                {
                    buttonTextDisplay.text += "<u>";
                 
                    yield return new WaitForSeconds(buttonTypingSpeed);
                }
                else if (letter == '}')
                {
                    buttonTextDisplay.text += "</u>";
                   
                    yield return new WaitForSeconds(buttonTypingSpeed);
                }

                else
                {
                    buttonTextDisplay.text += letter;
                    
                    yield return new WaitForSeconds(buttonTypingSpeed);
                }

        }
    }
    public void ButtonNextSentence()
    {
        buttonTextDisplay.text = "";
        StartCoroutine(ButtonType());
    }

    IEnumerator SafetyType()
    {
        foreach (char letter in safetySentences[safetyIndex].ToCharArray())
        {
            safetyTextDisplay.text += letter;
            yield return new WaitForSeconds(safetyTypingSpeed);
        }
    }

    public void SafetyNextSentence()
    {
        safetyTextDisplay.text = "";
        StartCoroutine(SafetyType());
    }

    private void Update()
    {

        if (buttonObject.GetComponent<InteractableManager>().pushCount == 1 && nextMessageCounter == 0)
        {
            buttonIndex += 1;
            ButtonNextSentence();
            nextMessageCounter += 1;
        }

        if (buttonObject.GetComponent<InteractableManager>().pushCount == 2 && nextMessageCounter == 1)
        {
            buttonIndex += 1;
            ButtonNextSentence();
            nextMessageCounter += 1;
        }
        if (buttonObject.GetComponent<InteractableManager>().pushCount == 3 && nextMessageCounter == 2)
        {
            buttonIndex += 1;
            ButtonNextSentence();
            nextMessageCounter += 1;
        }
        if (buttonObject.GetComponent<InteractableManager>().pushCount == 4 && nextMessageCounter == 3)
        {
            buttonIndex += 1;
            ButtonNextSentence();
            nextMessageCounter += 1;
        }
        if (buttonObject.GetComponent<InteractableManager>().pushCount == 6 && nextMessageCounter == 4)
        {
            buttonIndex += 1;
            ButtonNextSentence();
            nextMessageCounter += 1;
        }


        if (safetyTextDisplay.text == safetySentences[safetyIndex])
        {
            safetyIndex += 1;

            StartCoroutine(Wait());
        }
        if (safetyIndex == 7)
        {
            safetyIndex = 0;
        }

    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitBetweenSafetyMessages);
        SafetyNextSentence();
    }
}