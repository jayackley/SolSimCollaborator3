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
    public float buttonTypingSpeed;
    public int buttonIndex;
    public string[] buttonSentences;
    public float safetyTypingSpeed;
    public float waitBetweenSafetyMessages;
    public int safetyIndex;
    public string[] safetySentences;

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
        foreach (char letter in buttonSentences[buttonIndex].ToCharArray())
        {
            buttonTextDisplay.text += letter;
            yield return new WaitForSeconds(buttonTypingSpeed);
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