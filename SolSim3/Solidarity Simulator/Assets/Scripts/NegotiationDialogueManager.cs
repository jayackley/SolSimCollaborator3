using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NegotiationDialogueManager : MonoBehaviour {
    public TextMeshProUGUI textDisplay;
    public int index;
    public string whosTalking;
    public string[] sentences;
    public float typingSpeed;
    public float pauseTime;
    public GameObject solidarityPanel;
    public GameObject solidarityObject;
    public bool isTyping;
    public GameObject wrench;
    public GameObject orb;
    public GameObject mainCamera;
    public GameObject boardOptionManager;
    public bool primed;
    public int randomInsult;
    public float voxFadeSpeed;
    public float volumeZero;
    public float volumeMax;
    public float slowSpeed;
    public float fastSpeed;
    public GameObject strikeInstructionPanel;
    public GameObject sceneManager;
    public GameObject buttonInstruction;
    public GameObject negotiationSceneContainer;

    private void Awake()
    {
        isTyping = false;
    }

    IEnumerator Type()
    {
        isTyping = true;

        foreach (char letter in sentences[index])
        {
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
                yield return new WaitForSeconds(pauseTime / 2);
            }

            else if (letter == '^')
            {
                textDisplay.text += "\n";
                textDisplay.text += '_';
                yield return new WaitForSeconds(typingSpeed);
            }

            else if (letter == '@')
            {
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
    public void NextSentence()
    {
            textDisplay.text = "";
            StartCoroutine(Type());
    }
    private void Update()
    {
        /*
        if (isTyping == false)
        {
            primed = true;
        }
        else if (isTyping == true)
        {
            primed = false;
        }
        */

        if (isTyping == true & whosTalking == "wrench")
        {
            if (wrench.GetComponent<AudioSource>().volume < volumeMax)
            {
                wrench.GetComponent<AudioSource>().volume += voxFadeSpeed * Time.deltaTime;
            }
            wrench.GetComponent<Animator>().SetBool("IsTalking", true);
            orb.GetComponent<AudioSource>().volume = 0;
        }
 
        else if (isTyping == true & whosTalking == "orb")
        {
            if (orb.GetComponent<AudioSource>().volume < volumeMax)
            {
                orb.GetComponent<AudioSource>().volume += voxFadeSpeed * Time.deltaTime;
            }
            wrench.GetComponent<AudioSource>().volume = 0;
            wrench.GetComponent<Animator>().SetBool("IsTalking", false);
        }
       
        else if (isTyping == false)
        {
            if (wrench.GetComponent<AudioSource>().volume > volumeZero)
            {
                wrench.GetComponent<AudioSource>().volume -= voxFadeSpeed * Time.deltaTime;
            }
        
            if (orb.GetComponent<AudioSource>().volume > volumeZero)
            {
                orb.GetComponent<AudioSource>().volume -= voxFadeSpeed * Time.deltaTime;
            }

            wrench.GetComponent<Animator>().SetBool("IsTalking", false);

        }

        if (index == 50 || index == 52 || index == 53 || index == 55 || index == 57 || index == 60 || index == 62 || index == 64 || index == 66 || index == 68 || index == 70 || index == 72 || index == 75 || index == 77 || index == 80 || index == 82 || index == 85 || index == 87 || index == 88 || index == 90 || index == 92 || index == 96 || index == 98 || index == 100 || index == 102 || index ==104 || index == 106 || index == 107)
        {
            whosTalking = "orb";
            mainCamera.GetComponent<CameraManager>().whosFocus = "orb";
            textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 0, 42, 255);
            negotiationSceneContainer.GetComponent<NegotationSceneManager>().facingCamera = false;
        }
        else if (index == 51 || index == 54 || index == 56 || index == 58 || index == 59 || index == 61 || index == 63 || index == 65 || index == 67 || index == 69 || index == 71 || index == 73 || index == 74 || index == 76 || index == 78 || index == 79 || index == 81 || index == 83 || index == 84 || index == 86 || index == 89 || index == 91 || index == 93 || index == 94 || index == 95 || index == 97 || index == 99 || index == 101 || index == 103 || index == 105)
        {
            whosTalking = "wrench";
            mainCamera.GetComponent<CameraManager>().whosFocus = "wrench";
            textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(101, 100, 219, 255);
            negotiationSceneContainer.GetComponent<NegotationSceneManager>().facingCamera = true;
        }
    }

    private void OnGUI()
    {
//Negotiation scene

        //skip to end if out of leverage
        if (index == 107 && Event.current.Equals(Event.KeyboardEvent("return")))
        {
           sceneManager.GetComponent<SceneManager>().convoCounter = 14;
           gameObject.SetActive(false);
       }

        if (solidarityObject.GetComponent<SolidarityManager>().solidarity < 0 && Event.current.Equals(Event.KeyboardEvent("return")))
        {
            index = 107;
            NextSentence();
        }

        else if (index == 58 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 59;
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 40;
            NextSentence();
        }

        else if (index == 58 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 61;
            NextSentence();
        }

        else if (index == 60 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 63;
            NextSentence();
        }

        else if (index == 64 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 65;
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 10;
            NextSentence();
        }

        else if (index == 64 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 67;
            NextSentence();
        }

        else if (index == 66 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 69;
            NextSentence();
        }

        else if (index == 74 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 75;
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 30;
            NextSentence();
        }

        else if (index == 74 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 77;
            NextSentence();
        }

        else if (index == 76 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 79;
            NextSentence();
        }

        else if (index == 83 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 84;
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 20;
            NextSentence();
        }

        else if (index == 83 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 86;
            NextSentence();
        }

        else if (index == 84 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 88;
            NextSentence();
        }
        else if (index == 92 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 93;
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 60;
            NextSentence();
        }

        else if (index == 92 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 94;
            NextSentence();
        }

        else if (index == 93 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 95;
            NextSentence();
        }

        else if (index == 97 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 98;
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 40;
            NextSentence();
        }

        else if (index == 97 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 98;
            NextSentence();
        }

        else if (index == 102 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 1 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 103;
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 20;
            NextSentence();
        }

        else if (index == 102 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 2 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 105;
            NextSentence();
        }

        else if (index == 104 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 107;
            NextSentence();
        }

        else if (Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index += 1;
            NextSentence();
        }

        if (buttonInstruction.activeSelf == true && Event.current.Equals(Event.KeyboardEvent("return")))
        {
            buttonInstruction.SetActive(false);
        }
    }
}
