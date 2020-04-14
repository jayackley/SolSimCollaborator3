using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlackOutManager : MonoBehaviour
{

    public TextMeshProUGUI textDisplay;
    public int index;
    public string[] sentences;
    public float typingSpeed;
    public bool isTyping;
    public GameObject buttonInstruction;
    public bool primed;

    private void Start()
    {
        isTyping = false;
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    public void NextSentence()
    {
        textDisplay.text = "";
        StartCoroutine(Type());
    }
    private void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            isTyping = false;
        }
        else
        {
            isTyping = true;
        }

        if (isTyping == false)
        {
            primed = true;
        }
        else if (isTyping == true)
        {
            primed = false;
        }
    }
    private void OnGUI()
    {
        if (buttonInstruction.activeSelf == true && Event.current.Equals(Event.KeyboardEvent("return")))
        {
            buttonInstruction.SetActive(false);
        }
        if (Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            textDisplay.text = "";
            primed = false;
        }
    }
}