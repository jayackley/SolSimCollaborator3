using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BenefitTextManager : MonoBehaviour {

    public string[] sentences;
    public int index;
    public float typingSpeed;
    public TextMeshProUGUI textDisplay;

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

}
