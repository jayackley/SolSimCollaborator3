using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NegotiationDialogueManager : MonoBehaviour {

    public int numberOfWins;
    public bool healthcare;
    public bool dental;
    public bool childcare;
    public bool raises;
    public bool boardRep;
    public bool layoffProtections;
    public bool retirement;

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

        if (index == 0 ||index == 2 || index == 4 || index == 7 || index == 9 || index == 11 || index == 13 || index == 15 || index == 17 || index == 19 || index == 22 || index == 24 || index == 27 || index == 29 || index == 31 || index == 33 || index == 34 || index == 36 || index == 40 || index == 42 || index == 44 || index == 46 || index == 48 || index == 49)
        {
            whosTalking = "orb";
            mainCamera.GetComponent<CameraManager>().whosFocus = "orb";
            textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 0, 42, 255);
            negotiationSceneContainer.GetComponent<NegotationSceneManager>().facingCamera = false;
        }
        else 
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
        if (index == 49 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))))
        {
           sceneManager.GetComponent<SceneManager>().convoCounter = 14;
           gameObject.SetActive(false);
       }

        if (solidarityObject.GetComponent<SolidarityManager>().solidarity < 0 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))))
        {
            index = 49;
            NextSentence();
        }
        else if (index == 5 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 1 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false && solidarityObject.GetComponent<SolidarityManager>().solidarity < 40)
        {
            index = 49;
            NextSentence();
        }

        else if (index == 5 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 1 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false)
        {
            index = 6;
            healthcare = true;
            numberOfWins += 1;
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 40;
            NextSentence();
        }

        else if (index == 5 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 2 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false)
        {
            index = 8;
            NextSentence();
        }

        else if (index == 7 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false)
        {
            index = 10;
            NextSentence();
        }

        else if (index == 11 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 1 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false && solidarityObject.GetComponent<SolidarityManager>().solidarity < 10)
        {
            index = 49;
            NextSentence();
        }
        else if (index == 11 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 1 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false)
        {
            index = 12;
            dental = true;
            numberOfWins += 1;
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 10;
            NextSentence();
        }

        else if (index == 11 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 2 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false)
        {
            index = 14;
            NextSentence();
        }

        else if (index == 13 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false)
        {
            index = 16;
            NextSentence();
        }
        else if (index == 21 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 1 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false && solidarityObject.GetComponent<SolidarityManager>().solidarity < 30)
        {
            index = 49;
            NextSentence();
        }
        else if (index == 21 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 1 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false)
        {
            index = 22;
            childcare = true;
            numberOfWins += 1;
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 30;
            NextSentence();
        }

        else if (index == 21 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 2 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false)
        {
            index = 24;
            NextSentence();
        }

        else if (index == 23 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false)
        {
            index = 26;
            NextSentence();
        }
        else if (index == 29 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 1 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false && solidarityObject.GetComponent<SolidarityManager>().solidarity < 20)
        {
            index = 49;
            NextSentence();
        }
        else if (index == 29 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 1 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false)
        {
            index = 30;
            raises = true;
            numberOfWins += 1;
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 20;
            NextSentence();
        }

        else if (index == 29 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 2 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false)
        {
            index = 32;
            NextSentence();
        }

        else if (index == 31 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false)
        {
            index = 34;
            NextSentence();
        }
        else if (index == 36 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 1 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false && solidarityObject.GetComponent<SolidarityManager>().solidarity < 60)
        {
            index = 49;
            NextSentence();
        }
        else if (index == 36 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 1 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false)
        {
            index = 37;
            boardRep = true;
            numberOfWins += 1;
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 60;
            NextSentence();
        }

        else if (index == 36 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 2 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false)
        {
            index = 38;
            NextSentence();
        }

        else if (index == 37 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false)
        {
            index = 39;
            NextSentence();
        }
        else if (index == 39 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 1 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false && solidarityObject.GetComponent<SolidarityManager>().solidarity < 40)
        {
            index = 49;
            NextSentence();
        }

        else if (index == 39 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 1 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false)
        {
            index = 40;
            layoffProtections = true;
            numberOfWins += 1;
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 40;
            NextSentence();
        }

        else if (index == 39 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 2 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false)
        {
            index = 42;
            NextSentence();
        }

        else if (index == 41 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 1 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false && solidarityObject.GetComponent<SolidarityManager>().solidarity < 20)
        {
            index = 49;
            NextSentence();
        }
        else if (index == 41 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 1 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false)
        {
            index = 43;
            retirement = true;
            numberOfWins += 1;
            solidarityObject.GetComponent<SolidarityManager>().solidarity -= 20;
            NextSentence();
        }

        else if (index == 44 && boardOptionManager.GetComponent<BoardOptionManager>().currentSelect == 2 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false)
        {
            index = 45;
            NextSentence();
        }

        else if (index == 44 && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false)
        {
            index = 47;
            NextSentence();
        }

        else if ((Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))) && isTyping == false)
        {
            index += 1;
            NextSentence();
        }

        if (buttonInstruction.activeSelf == true && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))))
        {
            buttonInstruction.SetActive(false);
        }
    }
}
