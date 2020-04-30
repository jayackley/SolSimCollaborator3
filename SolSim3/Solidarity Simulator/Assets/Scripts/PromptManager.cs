﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PromptManager : MonoBehaviour {
    public GameObject optionManager;
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    public float typingSpeed;
    public float pauseTime;
    public bool isTyping;



    IEnumerator Type()
    {
        isTyping = true;

        foreach (char letter in sentences[optionManager.GetComponent<OptionManager>().sentenceIndex])
        {
            if (letter == '&')
            {
                Debug.Log("ampersand!");
                yield return new WaitForSeconds(pauseTime);
            }

            else if (letter == '.' || letter == '!' || letter == '?' || letter == ';')
            {
                textDisplay.text += letter;
                yield return new WaitForSeconds(pauseTime);
            }

            else if (letter == ',')
            {
                textDisplay.text += letter;
                yield return new WaitForSeconds(pauseTime/2);
            }

            else if (letter == '@')
            {
                isTyping = false;
                break;
            }

            else if (letter == '~')
            {

            }

            else
            {
                textDisplay.text += letter;
                yield return new WaitForSeconds(typingSpeed);
            }
        }
    }

    public void NextSentence()
    {
        if (optionManager.GetComponent<OptionManager>().sentenceIndex < sentences.Length)
        {
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
        }

    }
    /*
    private void Update()
    {
        if (textDisplay.text == sentences[optionManager.GetComponent<OptionManager>().sentenceIndex])
        {
            isTyping = false;
        }
        else
        {
            isTyping = true;
        }
    }
    */
}
