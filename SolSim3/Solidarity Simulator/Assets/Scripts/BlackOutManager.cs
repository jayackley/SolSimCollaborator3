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
    public float pauseTime;


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