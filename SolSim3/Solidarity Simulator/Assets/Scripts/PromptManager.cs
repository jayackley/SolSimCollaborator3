using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PromptManager : MonoBehaviour {
    public GameObject optionManager;
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    public float typingSpeed;
    public float pauseTime;
    public float slowSpeed;
    public float fastSpeed;
    public bool isTyping;



    IEnumerator Type()
    {
        isTyping = true;

        foreach (char letter in sentences[optionManager.GetComponent<OptionManager>().sentenceIndex])
        {
            if (isTyping == false)
                {
                break;
            }
            if (textDisplay.text.Length > 0)
            {
                textDisplay.text = textDisplay.text.Substring(0, textDisplay.text.Length - 1);
            }

            if (letter == '&')
            {
                Debug.Log("ampersand!");
                yield return new WaitForSeconds(pauseTime);
            }

            else if (letter == '.' || letter == '!' || letter == '?' || letter == ';')
            {
                textDisplay.text += letter;
                textDisplay.text += '_';
                yield return new WaitForSeconds(pauseTime);
            }

            else if (letter == ',')
            {
                textDisplay.text += letter;
                textDisplay.text += '_';
                yield return new WaitForSeconds(pauseTime/2);
            }

            else if (letter == '^')
            {
                textDisplay.text += "\n";
                textDisplay.text += '_';
                yield return new WaitForSeconds(typingSpeed);
            }

            else if (letter == '@')
            {
                optionManager.GetComponent<OptionManager>().primed = true;
                isTyping = false;
                break;
            }

            else if (letter == '{')
            {
                textDisplay.text += "<u>";
                textDisplay.text += '_';
                yield return new WaitForSeconds(typingSpeed);
            }
            else if (letter == '}')
            {
                textDisplay.text += "</u>";
                textDisplay.text += '_';
                yield return new WaitForSeconds(typingSpeed);
            }

            else if (letter == '[')
            {
                typingSpeed = slowSpeed;
                textDisplay.text += '_';
            }
            else if (letter == ']')
            {
                typingSpeed = fastSpeed;
                textDisplay.text += '_';
            }

            else
            {
                textDisplay.text += letter;
                textDisplay.text += '_';
                yield return new WaitForSeconds(typingSpeed);
            }

        }  
    }
    /*
    public void CompleteSentence()
    {
        isTyping = false;
        StopCoroutine(Type());
        textDisplay.text = "";
        textDisplay.text = sentences[optionManager.GetComponent<OptionManager>().sentenceIndex];

    }
    */
    public void NextSentence()
    {
        optionManager.GetComponent<OptionManager>().primed = false;
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
