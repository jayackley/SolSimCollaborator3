﻿using System.Collections;
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
    public float pauseTime;
    public GameObject endGameManager;

    private void Awake()
    {
        textDisplay.faceColor = new Color32(245, 254, 1,255);
        textDisplay.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Center;
        textDisplay.GetComponent<TextMeshProUGUI>().fontSize = 30;
    }

    IEnumerator Type()
    {
        isTyping = true;

        foreach (char letter in sentences[index])
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
                yield return new WaitForSeconds(pauseTime / 2);
            }

            else if (letter == '^')
            {
                textDisplay.text += "\n";
                yield return new WaitForSeconds(typingSpeed);
            }

            else if (letter == '@')
            {
                isTyping = false;
                break;
            }

            else if (letter == '{')
            {
                textDisplay.text += "<size=+14>";
                yield return new WaitForSeconds(typingSpeed);
            }
            else if (letter == '}')
            {
                textDisplay.text += "</size>";
                yield return new WaitForSeconds(typingSpeed);
            }

            else if (letter == '<')
            {
                textDisplay.text += "<size=-10>";
                yield return new WaitForSeconds(typingSpeed);
            }
            else if (letter == '>')
            {
                textDisplay.text += "</size>";
                yield return new WaitForSeconds(typingSpeed);
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
        textDisplay.text = "";
        StartCoroutine(Type());
    }
    private void Update()
    {


        if (isTyping == false)
        {
            primed = true;
        }
        else if (isTyping == true)
        {
            primed = false;
        }
        if (index == 4 )
        {
            textDisplay.GetComponent<TextMeshProUGUI>().alignment = TextAlignmentOptions.Top;
            textDisplay.GetComponent<TextMeshProUGUI>().fontSize = 20;
            endGameManager.SetActive(true);

        }



    }
    private void OnGUI()
    {
        if (buttonInstruction.activeSelf == true && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))))
        {
            buttonInstruction.SetActive(false);
        }
        if ((Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false && index != 4)
        {
            textDisplay.text = "";
            primed = false;
        }
    }
}