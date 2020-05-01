using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StrikeInstructionManager : MonoBehaviour
{

    public TextMeshProUGUI textDisplay;
    public int index;
    public string[] sentences;
    public float typingSpeed;
    public bool isTyping;
    public bool primed;
    public GameObject scabSpawnPoint;
    public GameObject mainCameraManager;
    public GameObject sceneManager;


    private void Awake()
    {
        isTyping = false;
        NextSentence();
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
        if (index == 4)
        {
            scabSpawnPoint.GetComponent<ScabSpawnManager>().ShootScab();
            primed = false;
            gameObject.SetActive(false);     
        }
        if (index == 6) 
        {
            primed = false;
            mainCameraManager.GetComponent<CameraManager>().whosFocus = "orb";
            mainCameraManager.GetComponent<CameraManager>().scene = "negotiate";
            sceneManager.GetComponent<SceneManager>().convoCounter = 12;
            gameObject.SetActive(false);
        }
    }
    private void OnGUI()
    {
        if (Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index += 1;
            textDisplay.text = "";
            primed = false;
            NextSentence();
        }
    }
}