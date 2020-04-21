using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoardManager : MonoBehaviour {
    public TextMeshProUGUI textDisplay;
    public int index;
    public string whosTalking;
    public string[] sentences;
    public float typingSpeed;
    public GameObject solidarityPanel;
    public GameObject solidarityObject;
    public bool isTyping;
    public GameObject wrench;
    public GameObject temp;
    public GameObject welder;
    public GameObject bigGuy;
    public GameObject data;
    public GameObject accounting;
    public GameObject manager;
    public GameObject orb;
    public GameObject corporate;
    public GameObject mainCamera;
    public GameObject buttonInstruction;
    public GameObject boardOptionManager;
    public bool primed;
    public int randomInsult;
    public float voxFadeSpeed;
    public float volumeZero;
    public float volumeMax;
    public GameObject strikePongContainer;
    public GameObject strikeInstructionPanel;
    public GameObject sceneManager;

    private void Awake()
    {
        isTyping = false;
        randomInsult = Random.Range(1, 4);
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

        if (isTyping == true & whosTalking == "wrench")
        {
            if (wrench.GetComponent<AudioSource>().volume < volumeMax)
            {
                wrench.GetComponent<AudioSource>().volume += voxFadeSpeed * Time.deltaTime;
            }
            wrench.GetComponent<Animator>().SetBool("IsTalking", true);

            temp.GetComponent<AudioSource>().volume = 0;
            welder.GetComponent<AudioSource>().volume = 0;
            bigGuy.GetComponent<AudioSource>().volume = 0;
            data.GetComponent<AudioSource>().volume = 0;
            accounting.GetComponent<AudioSource>().volume = 0;
            manager.GetComponent<AudioSource>().volume = 0;
            orb.GetComponent<AudioSource>().volume = 0;
            corporate.GetComponent<AudioSource>().volume = 0;
        }
        else if (isTyping == true & whosTalking == "temp")
        {
            if (temp.GetComponent<AudioSource>().volume < volumeMax)
            {
                temp.GetComponent<AudioSource>().volume += voxFadeSpeed * Time.deltaTime;
            }
            wrench.GetComponent<AudioSource>().volume = 0;
            welder.GetComponent<AudioSource>().volume = 0;
            bigGuy.GetComponent<AudioSource>().volume = 0;
            data.GetComponent<AudioSource>().volume = 0;
            accounting.GetComponent<AudioSource>().volume = 0;
            manager.GetComponent<AudioSource>().volume = 0;
            orb.GetComponent<AudioSource>().volume = 0;
            corporate.GetComponent<AudioSource>().volume = 0;
        }
        else if (isTyping == true & whosTalking == "welder")
        {
            typingSpeed = 0.02f;
            if (welder.GetComponent<AudioSource>().volume < volumeMax)
            {
                welder.GetComponent<AudioSource>().volume += voxFadeSpeed * Time.deltaTime;
            }
            wrench.GetComponent<AudioSource>().volume = 0;
            temp.GetComponent<AudioSource>().volume = 0;
            bigGuy.GetComponent<AudioSource>().volume = 0;
            data.GetComponent<AudioSource>().volume = 0;
            accounting.GetComponent<AudioSource>().volume = 0;
            manager.GetComponent<AudioSource>().volume = 0;
            orb.GetComponent<AudioSource>().volume = 0;
            corporate.GetComponent<AudioSource>().volume = 0;
        }
        else if (isTyping == true & whosTalking == "bigguy")
        {
            if (bigGuy.GetComponent<AudioSource>().volume < volumeMax)
            {
                bigGuy.GetComponent<AudioSource>().volume += voxFadeSpeed * Time.deltaTime;
            }
            wrench.GetComponent<AudioSource>().volume = 0;
            temp.GetComponent<AudioSource>().volume = 0;
            welder.GetComponent<AudioSource>().volume = 0;
            data.GetComponent<AudioSource>().volume = 0;
            accounting.GetComponent<AudioSource>().volume = 0;
            manager.GetComponent<AudioSource>().volume = 0;
            orb.GetComponent<AudioSource>().volume = 0;
            corporate.GetComponent<AudioSource>().volume = 0;
            typingSpeed = 0.06f;
        }
        else if (isTyping == true & whosTalking == "data")
        {
            if (data.GetComponent<AudioSource>().volume < volumeMax)
            {
                data.GetComponent<AudioSource>().volume += voxFadeSpeed * Time.deltaTime;
            }
            wrench.GetComponent<AudioSource>().volume = 0;
            temp.GetComponent<AudioSource>().volume = 0;
            welder.GetComponent<AudioSource>().volume = 0;
            bigGuy.GetComponent<AudioSource>().volume = 0;
            accounting.GetComponent<AudioSource>().volume = 0;
            manager.GetComponent<AudioSource>().volume = 0;
            orb.GetComponent<AudioSource>().volume = 0;
            corporate.GetComponent<AudioSource>().volume = 0;
        }
        else if (isTyping == true & whosTalking == "accounting")
        {
            if (accounting.GetComponent<AudioSource>().volume < volumeMax)
            {
                accounting.GetComponent<AudioSource>().volume += voxFadeSpeed * Time.deltaTime;
            }
            wrench.GetComponent<AudioSource>().volume = 0;
            temp.GetComponent<AudioSource>().volume = 0;
            welder.GetComponent<AudioSource>().volume = 0;
            bigGuy.GetComponent<AudioSource>().volume = 0;
            data.GetComponent<AudioSource>().volume = 0;
            manager.GetComponent<AudioSource>().volume = 0;
            orb.GetComponent<AudioSource>().volume = 0;
            corporate.GetComponent<AudioSource>().volume = 0;
        }
        else if (isTyping == true & whosTalking == "manager")
        {
            if (manager.GetComponent<AudioSource>().volume < volumeMax)
            {
                manager.GetComponent<AudioSource>().volume += voxFadeSpeed * Time.deltaTime;
            }
            wrench.GetComponent<AudioSource>().volume = 0;
            temp.GetComponent<AudioSource>().volume = 0;
            welder.GetComponent<AudioSource>().volume = 0;
            bigGuy.GetComponent<AudioSource>().volume = 0;
            data.GetComponent<AudioSource>().volume = 0;
            accounting.GetComponent<AudioSource>().volume = 0;
            orb.GetComponent<AudioSource>().volume = 0;
            corporate.GetComponent<AudioSource>().volume = 0;
        }
        else if (isTyping == true & whosTalking == "orb")
        {
            if (orb.GetComponent<AudioSource>().volume < volumeMax)
            {
                orb.GetComponent<AudioSource>().volume += voxFadeSpeed * Time.deltaTime;
            }
            wrench.GetComponent<AudioSource>().volume = 0;
            temp.GetComponent<AudioSource>().volume = 0;
            welder.GetComponent<AudioSource>().volume = 0;
            bigGuy.GetComponent<AudioSource>().volume = 0;
            data.GetComponent<AudioSource>().volume = 0;
            accounting.GetComponent<AudioSource>().volume = 0;
            manager.GetComponent<AudioSource>().volume = 0;
            corporate.GetComponent<AudioSource>().volume = 0;
        }
        else if (isTyping == true & whosTalking == "corporate")
        {
            if (corporate.GetComponent<AudioSource>().volume < volumeMax)
            {
                corporate.GetComponent<AudioSource>().volume += voxFadeSpeed * Time.deltaTime;
            }
            wrench.GetComponent<AudioSource>().volume = 0;
            temp.GetComponent<AudioSource>().volume = 0;
            welder.GetComponent<AudioSource>().volume = 0;
            bigGuy.GetComponent<AudioSource>().volume = 0;
            data.GetComponent<AudioSource>().volume = 0;
            accounting.GetComponent<AudioSource>().volume = 0;
            manager.GetComponent<AudioSource>().volume = 0;
            orb.GetComponent<AudioSource>().volume = 0;
        }
        else if (isTyping == false)
        {
            if (wrench.GetComponent<AudioSource>().volume > volumeZero)
            {
                wrench.GetComponent<AudioSource>().volume -= voxFadeSpeed * Time.deltaTime;
            }
            if (temp.GetComponent<AudioSource>().volume > volumeZero)
            {
                temp.GetComponent<AudioSource>().volume -= voxFadeSpeed * Time.deltaTime;
            }
            if (welder.GetComponent<AudioSource>().volume > volumeZero)
            {
                welder.GetComponent<AudioSource>().volume -= voxFadeSpeed * Time.deltaTime;
            }
            if (bigGuy.GetComponent<AudioSource>().volume > volumeZero)
            {
                bigGuy.GetComponent<AudioSource>().volume -= voxFadeSpeed * Time.deltaTime;
            }
            if (data.GetComponent<AudioSource>().volume > volumeZero)
            {
                data.GetComponent<AudioSource>().volume -= voxFadeSpeed * Time.deltaTime;
            }
            if (accounting.GetComponent<AudioSource>().volume > volumeZero)
            {
                accounting.GetComponent<AudioSource>().volume -= voxFadeSpeed * Time.deltaTime;
            }
            if (manager.GetComponent<AudioSource>().volume > volumeZero)
            {
                manager.GetComponent<AudioSource>().volume -= voxFadeSpeed * Time.deltaTime;
            }
            if (orb.GetComponent<AudioSource>().volume > volumeZero)
            {
                orb.GetComponent<AudioSource>().volume -= voxFadeSpeed * Time.deltaTime;
            }
            if (corporate.GetComponent<AudioSource>().volume > volumeZero)
            {
                corporate.GetComponent<AudioSource>().volume -= voxFadeSpeed * Time.deltaTime;
            }
            typingSpeed = 0.02f;

            wrench.GetComponent<Animator>().SetBool("IsTalking", false);

        }

        if (index == 1 || index == 12 || index == 21 || index == 50 || index == 52 || index == 53 || index == 55 || index == 57 || index == 60 || index == 62 || index == 64 || index == 66 || index == 68 || index == 70 || index == 72 || index == 75 || index == 77 || index == 80 || index == 82 || index == 85 || index == 87 || index == 88 || index == 90 || index == 92 || index == 96 || index == 98 || index == 100 || index == 102 || index ==104 || index == 106 || index == 107)
        {
            whosTalking = "orb";
            mainCamera.GetComponent<CameraManager>().whosFocus = "orb";
            textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 0, 42, 255);
        }
        else if (index == 2 || index == 16 || index == 18 || index == 23 || index == 24)
        {
            whosTalking = "accounting";
            mainCamera.GetComponent<CameraManager>().whosFocus = "accounting";
            textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 148, 0, 255);


        }
        else if (index == 0 || index == 3 || index == 6 || index == 14 || index == 19)
        {
            whosTalking = "corporate";
            mainCamera.GetComponent<CameraManager>().whosFocus = "corporate";
            textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 55, 0, 255);

        }
        else if (index == 4 || index == 31 || index == 32)
        {
            whosTalking = "bigguy";
            mainCamera.GetComponent<CameraManager>().whosFocus = "bigguy";
            textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(16, 83, 73, 255);

        }
        else if (index == 5 || index == 17 || index == 27 || index == 28 || (index >= 34 && index <50))
        {
            whosTalking = "welder";
            mainCamera.GetComponent<CameraManager>().whosFocus = "welder";
            textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 195, 0, 255);

        }
        else if (index == 7)
        {
            whosTalking = "manager";
            mainCamera.GetComponent<CameraManager>().whosFocus = "manager";
            textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(127, 5, 40, 255);

        }
        else if (index == 8 || index == 10 || index == 13|| index == 15 || index == 20 || index == 22 || index == 51 || index == 54 || index == 56 || index == 58 || index == 59 || index == 61 || index == 63 || index == 65 || index == 67 || index == 69 || index == 71 || index == 73 || index == 74 || index == 76 || index == 78 || index == 79 || index == 81 || index == 83 || index == 84 || index == 86 || index == 89 || index == 91 || index == 93 || index == 94 || index == 95 || index == 97 || index == 99 || index == 101 || index == 103 || index == 105)
        {
            whosTalking = "wrench";
            mainCamera.GetComponent<CameraManager>().whosFocus = "wrench";
            textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(101, 100, 219, 255);

        }
        else if (index == 9 || index == 25 || index == 26)
        {
            whosTalking = "data";
            mainCamera.GetComponent<CameraManager>().whosFocus = "data";
            textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255,255,255, 255);
            textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 255, 255, 255);

        }

        else if (index == 11 || index == 29 || index == 30)
        {
            whosTalking = "temp";
            mainCamera.GetComponent<CameraManager>().whosFocus = "temp";
            textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(137, 210, 220, 255);
        }
        else if (index == 33)
        {
            mainCamera.GetComponent<CameraManager>().whosFocus = "pc";
            whosTalking = "temp";
            textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(137, 210, 220, 255);
        }
    }

    private void OnGUI()
    {
        if (index == 22 && solidarityObject.GetComponent<SolidarityManager>().solidarity >= 30 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 23;
            NextSentence();
        }

        else if (index == 22 && solidarityObject.GetComponent<SolidarityManager>().solidarity < 30 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 24;
            NextSentence();
        }

        else if ((index == 23 || index == 24) && solidarityObject.GetComponent<SolidarityManager>().solidarity >= 50 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 25;
            NextSentence();
        }

        else if ((index == 23 || index == 24) && solidarityObject.GetComponent<SolidarityManager>().solidarity < 50 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 26;
            NextSentence();
        }

        else if ((index == 25 || index == 26) && solidarityObject.GetComponent<SolidarityManager>().solidarity >= 70 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 27;
            NextSentence();
        }

        else if ((index == 25 || index == 26) && solidarityObject.GetComponent<SolidarityManager>().solidarity < 70 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 28;
            NextSentence();
        }
        else if ((index == 27 || index == 28) && solidarityObject.GetComponent<SolidarityManager>().solidarity >= 90 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 29;
            NextSentence();
        }

        else if ((index == 27 || index == 28) && solidarityObject.GetComponent<SolidarityManager>().solidarity < 90 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 30;
            NextSentence();
        }
        else if ((index == 29 || index == 30) && solidarityObject.GetComponent<SolidarityManager>().solidarity >= 110 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 31;
            NextSentence();
        }

        else if ((index == 29 || index == 30) && solidarityObject.GetComponent<SolidarityManager>().solidarity < 110 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 32;
            NextSentence();
        }
        else if ((index == 31 || index == 32) && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 33;
            NextSentence();
        }

        else if (index == 33 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 110;
            mainCamera.GetComponent<CameraManager>().whosFocus = "strikepong";
            strikePongContainer.SetActive(true);
            strikeInstructionPanel.SetActive(true);
            primed = false;
            gameObject.SetActive(false);
            solidarityPanel.transform.localPosition = new Vector3(250, 245, 0);
        }

        else if (Event.current.Equals(Event.KeyboardEvent("s")))
        {
            index = 110;
            mainCamera.GetComponent<CameraManager>().whosFocus = "strikepong";
            strikePongContainer.SetActive(true);
            strikeInstructionPanel.SetActive(true);
            primed = false;
            gameObject.SetActive(false);
            solidarityPanel.transform.localPosition = new Vector3(250, 245, 0);
        }

//random insult generator

        else if (index == 16 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false && randomInsult ==1)
        {
            index = 17;
            NextSentence();
        }

        else if (index == 16 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false && randomInsult == 2)
        {
            index = 34;
            NextSentence();
        }

        else if (index == 16 && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false && randomInsult == 3)
        {
            index = 35;
            NextSentence();
        }

        else if ((index == 34|| index == 35) && Event.current.Equals(Event.KeyboardEvent("return")) && isTyping == false)
        {
            index = 18;
            NextSentence();
        }
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

        else if (buttonInstruction.activeSelf == true && Event.current.Equals(Event.KeyboardEvent("return")))
        {
            buttonInstruction.SetActive(false);
        }
    }
}
