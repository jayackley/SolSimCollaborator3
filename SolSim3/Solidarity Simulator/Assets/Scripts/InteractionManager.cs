using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractionManager : MonoBehaviour
{
    public GameObject negotiationManager;
    public bool dialogueVisible;
    public GameObject uiCanvas;
    public GameObject playerObject;
    public GameObject sceneManager;
    public GameObject promptPanel;
    public GameObject promptText;
    public GameObject optionManager;
    public GameObject optionOne;
    public GameObject optionTwo;
    public GameObject optionThree;
    public GameObject solidarityPanel;
    public string whosTalking;
    public GameObject wrench;
    public GameObject temp;
    public GameObject welder;
    public GameObject bigGuy;
    public GameObject data;
    public GameObject accounting;
    public GameObject manager;
    public GameObject blackOutManager;
    public GameObject mainCamera;
    public GameObject pressCircle;
    public GameObject buttonInstruction;
    public float voxFadeSpeed;
    public float zeroVolume;
    public float maxVolume;
    public GameObject achievementManager;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ClimbAchievement")
        {
            achievementManager.GetComponent<AchievementManager>().topclimbtrigger = true;
        }
        if (collision.gameObject.name == "Wrench")
        {
            optionManager.GetComponent<OptionManager>().enabled = true;
            playerObject.GetComponent<MovementController>().canPoke = false;
            dialogueVisible = true;
            uiCanvas.GetComponent<Canvas>().enabled = true;
            playerObject.GetComponent<MovementController>().enabled = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            sceneManager.GetComponent<SceneManager>().convoCounter += 1;
            if (sceneManager.GetComponent<SceneManager>().convoCounter <= 7)
            {
                optionManager.GetComponent<OptionManager>().sentenceIndex = 0;
            }
            else if (sceneManager.GetComponent<SceneManager>().convoCounter > 7 && negotiationManager.GetComponent<NegotiationDialogueManager>().layoffProtections == true)
            {
                optionManager.GetComponent<OptionManager>().sentenceIndex = 61;
            }
            else if (sceneManager.GetComponent<SceneManager>().convoCounter > 7 && negotiationManager.GetComponent<NegotiationDialogueManager>().layoffProtections == false)
            {
                optionManager.GetComponent<OptionManager>().sentenceIndex = 62;
            }
            promptPanel.GetComponent<PromptManager>().NextSentence();
            playerObject.GetComponent<Animator>().SetBool("iswalking", false);
            playerObject.GetComponent<Animator>().SetBool("isjumping", false);
            playerObject.GetComponent<Animator>().SetBool("isfalling", false);
            whosTalking = "wrench";
            promptText.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            promptText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(101, 100, 219, 255);
            promptPanel.transform.localPosition = new Vector3(170, 150, 0);
            optionOne.transform.localPosition = new Vector3(-221, -200, 0);
            optionTwo.transform.localPosition = new Vector3(-221, 50, 0);
            optionThree.transform.localPosition = new Vector3(-221, -75, 0);
            solidarityPanel.transform.localPosition = new Vector3(250, -235, 0);
            optionManager.GetComponent<OptionManager>().currentSelect = 2;
            playerObject.GetComponent<SpriteRenderer>().flipX = true;
            mainCamera.GetComponent<CameraManager>().whosFocus = "wrench";
            pressCircle.transform.localPosition = new Vector3(317, 77, 0);
            buttonInstruction.transform.localPosition = new Vector3(-290, -200, 0);

        }

        else if (collision.gameObject.name == "Temp")
        {
            optionManager.GetComponent<OptionManager>().enabled = true;
            playerObject.GetComponent<MovementController>().canPoke = false;
            dialogueVisible = true;
            uiCanvas.GetComponent<Canvas>().enabled = true;
            playerObject.GetComponent<MovementController>().enabled = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            sceneManager.GetComponent<SceneManager>().convoCounter += 1;
            if (sceneManager.GetComponent<SceneManager>().convoCounter <= 7)
            {
                optionManager.GetComponent<OptionManager>().sentenceIndex = 11;
            }
            else if (sceneManager.GetComponent<SceneManager>().convoCounter > 7 && negotiationManager.GetComponent<NegotiationDialogueManager>().dental == true)
            {
                optionManager.GetComponent<OptionManager>().sentenceIndex = 64;
            }
            else if (sceneManager.GetComponent<SceneManager>().convoCounter > 7 && negotiationManager.GetComponent<NegotiationDialogueManager>().dental == false)
            {
                optionManager.GetComponent<OptionManager>().sentenceIndex = 65;
            }
            promptPanel.GetComponent<PromptManager>().NextSentence();
            playerObject.GetComponent<Animator>().SetBool("iswalking", false);
            playerObject.GetComponent<Animator>().SetBool("isjumping", false);
            playerObject.GetComponent<Animator>().SetBool("isfalling", false);
            whosTalking = "temp";
            promptText.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            promptText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(137, 210, 220, 255);
            promptPanel.transform.localPosition = new Vector3(-170, 150, 0);
            optionOne.transform.localPosition = new Vector3(221, -200, 0);
            optionTwo.transform.localPosition = new Vector3(221, 50, 0);
            optionThree.transform.localPosition = new Vector3(221, -75, 0);
            solidarityPanel.transform.localPosition = new Vector3(-250, -235, 0);
            optionManager.GetComponent<OptionManager>().currentSelect = 2;
            playerObject.GetComponent<SpriteRenderer>().flipX = false;
            pressCircle.transform.localPosition = new Vector3(-23, 77, 0);
            buttonInstruction.transform.localPosition = new Vector3(-7, 70, 0);
        }


        else if (collision.gameObject.name == "WelderArea")
        {
            optionManager.GetComponent<OptionManager>().enabled = true;
            playerObject.GetComponent<MovementController>().canPoke = false;
            dialogueVisible = true;
            uiCanvas.GetComponent<Canvas>().enabled = true;
            playerObject.GetComponent<MovementController>().enabled = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            sceneManager.GetComponent<SceneManager>().convoCounter += 1;
            if (sceneManager.GetComponent<SceneManager>().convoCounter <= 7)
            {
                optionManager.GetComponent<OptionManager>().sentenceIndex = 21;
            }
            else if (sceneManager.GetComponent<SceneManager>().convoCounter > 7 && negotiationManager.GetComponent<NegotiationDialogueManager>().healthcare == true)
            {
                optionManager.GetComponent<OptionManager>().sentenceIndex = 67;
            }
            else if (sceneManager.GetComponent<SceneManager>().convoCounter > 7 && negotiationManager.GetComponent<NegotiationDialogueManager>().healthcare == false)
            {
                optionManager.GetComponent<OptionManager>().sentenceIndex = 68;
            }
            promptPanel.GetComponent<PromptManager>().NextSentence();
            playerObject.GetComponent<Animator>().SetBool("iswalking", true);
            playerObject.GetComponent<Animator>().SetBool("isjumping", false);
            playerObject.GetComponent<Animator>().SetBool("isfalling", false);
            whosTalking = "welder";
            promptText.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            promptText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 195, 0, 255);
            promptPanel.transform.localPosition = new Vector3(-170, 150, 0);
            optionOne.transform.localPosition = new Vector3(221, -200, 0);
            optionTwo.transform.localPosition = new Vector3(221, 50, 0);
            optionThree.transform.localPosition = new Vector3(221, -75, 0);
            solidarityPanel.transform.localPosition = new Vector3(-250, -235, 0);
            optionManager.GetComponent<OptionManager>().currentSelect = 2;
            mainCamera.GetComponent<CameraManager>().whosFocus = "welder";
            playerObject.GetComponent<SpriteRenderer>().flipX = false;
            pressCircle.transform.localPosition = new Vector3(-23, 77, 0);
            buttonInstruction.transform.localPosition = new Vector3(-7, 70, 0);
        }

        else if (collision.gameObject.name == "BigGuy")
        {
            optionManager.GetComponent<OptionManager>().enabled = true;
            playerObject.GetComponent<MovementController>().canPoke = false;
            dialogueVisible = true;
            uiCanvas.GetComponent<Canvas>().enabled = true;
            playerObject.GetComponent<MovementController>().enabled = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            sceneManager.GetComponent<SceneManager>().convoCounter += 1;
            if (sceneManager.GetComponent<SceneManager>().convoCounter <= 7)
            {
                optionManager.GetComponent<OptionManager>().sentenceIndex = 29;
            }
            else if (sceneManager.GetComponent<SceneManager>().convoCounter > 7 && negotiationManager.GetComponent<NegotiationDialogueManager>().childcare == true)
            {
                optionManager.GetComponent<OptionManager>().sentenceIndex = 70;
            }
            else if (sceneManager.GetComponent<SceneManager>().convoCounter > 7 && negotiationManager.GetComponent<NegotiationDialogueManager>().childcare == false)
            {
                optionManager.GetComponent<OptionManager>().sentenceIndex = 71;
            }
            promptPanel.GetComponent<PromptManager>().NextSentence();
            playerObject.GetComponent<Animator>().SetBool("iswalking", false);
            playerObject.GetComponent<Animator>().SetBool("isjumping", false);
            playerObject.GetComponent<Animator>().SetBool("isfalling", false);
            whosTalking = "bigguy";
            promptText.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            promptText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(16, 83, 73, 255);
            promptPanel.transform.localPosition = new Vector3(170, 150, 0);
            optionOne.transform.localPosition = new Vector3(-221, -200, 0);
            optionTwo.transform.localPosition = new Vector3(-221, 50, 0);
            optionThree.transform.localPosition = new Vector3(-221, -75, 0);
            solidarityPanel.transform.localPosition = new Vector3(250, -235, 0);
            optionManager.GetComponent<OptionManager>().currentSelect = 2;
            mainCamera.GetComponent<CameraManager>().whosFocus = "bigguy";
            pressCircle.transform.localPosition = new Vector3(317, 77, 0);
            buttonInstruction.transform.localPosition = new Vector3(-290, -200, 0);
        }

        else if (collision.gameObject.name == "Data")
        {
            optionManager.GetComponent<OptionManager>().enabled = true;
            playerObject.GetComponent<MovementController>().canPoke = false;
            dialogueVisible = true;
            uiCanvas.GetComponent<Canvas>().enabled = true;
            playerObject.GetComponent<MovementController>().enabled = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            sceneManager.GetComponent<SceneManager>().convoCounter += 1;
            if (sceneManager.GetComponent<SceneManager>().convoCounter <= 7)
            {
                optionManager.GetComponent<OptionManager>().sentenceIndex = 36;
            }
            else if (sceneManager.GetComponent<SceneManager>().convoCounter > 7 && negotiationManager.GetComponent<NegotiationDialogueManager>().raises == true)
            {
                optionManager.GetComponent<OptionManager>().sentenceIndex = 73;
            }
            else if (sceneManager.GetComponent<SceneManager>().convoCounter > 7 && negotiationManager.GetComponent<NegotiationDialogueManager>().raises == false)
            {
                optionManager.GetComponent<OptionManager>().sentenceIndex = 74;
            }
            promptPanel.GetComponent<PromptManager>().NextSentence();
            playerObject.GetComponent<Animator>().SetBool("iswalking", false);
            playerObject.GetComponent<Animator>().SetBool("isjumping", false);
            playerObject.GetComponent<Animator>().SetBool("isfalling", false);
            whosTalking = "data";
            promptText.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            promptText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 255, 255, 255);
            promptPanel.transform.localPosition = new Vector3(170, 150, 0);
            optionOne.transform.localPosition = new Vector3(-221, -200, 0);
            optionTwo.transform.localPosition = new Vector3(-221, 50, 0);
            optionThree.transform.localPosition = new Vector3(-221, -75, 0);
            solidarityPanel.transform.localPosition = new Vector3(250, -235, 0);
            optionManager.GetComponent<OptionManager>().currentSelect = 2;
            mainCamera.GetComponent<CameraManager>().whosFocus = "data";
            pressCircle.transform.localPosition = new Vector3(317, 77, 0);
            buttonInstruction.transform.localPosition = new Vector3(-290, -200, 0);
        }

        else if (collision.gameObject.name == "Accounting")
        {
            optionManager.GetComponent<OptionManager>().enabled = true;
            playerObject.GetComponent<MovementController>().canPoke = false;
            dialogueVisible = true;
            uiCanvas.GetComponent<Canvas>().enabled = true;
            playerObject.GetComponent<MovementController>().enabled = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            sceneManager.GetComponent<SceneManager>().convoCounter += 1;
            if (sceneManager.GetComponent<SceneManager>().convoCounter <= 7)
            {
                optionManager.GetComponent<OptionManager>().sentenceIndex = 42;
            }
            else if (sceneManager.GetComponent<SceneManager>().convoCounter > 7 && negotiationManager.GetComponent<NegotiationDialogueManager>().boardRep == true)
            {
                optionManager.GetComponent<OptionManager>().sentenceIndex = 76;
            }
            else if (sceneManager.GetComponent<SceneManager>().convoCounter > 7 && negotiationManager.GetComponent<NegotiationDialogueManager>().boardRep == false)
            {
                optionManager.GetComponent<OptionManager>().sentenceIndex = 77;
            }

            promptPanel.GetComponent<PromptManager>().NextSentence();
            playerObject.GetComponent<Animator>().SetBool("iswalking", false);
            playerObject.GetComponent<Animator>().SetBool("isjumping", false);
            playerObject.GetComponent<Animator>().SetBool("isfalling", false);
            whosTalking = "accounting";
            promptText.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            promptText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 148, 0, 255);
            promptPanel.transform.localPosition = new Vector3(170, 150, 0);
            optionOne.transform.localPosition = new Vector3(-221, -200, 0);
            optionTwo.transform.localPosition = new Vector3(-221, 50, 0);
            optionThree.transform.localPosition = new Vector3(-221, -75, 0);
            solidarityPanel.transform.localPosition = new Vector3(250, -235, 0);
            optionManager.GetComponent<OptionManager>().currentSelect = 2;
            mainCamera.GetComponent<CameraManager>().whosFocus = "accounting";
            pressCircle.transform.localPosition = new Vector3(317, 77, 0);
            buttonInstruction.transform.localPosition = new Vector3(-290, -200, 0);
        }
        else if (collision.gameObject.name == "Manager" && collision is CapsuleCollider2D)
        {
            optionManager.GetComponent<OptionManager>().enabled = true;
            playerObject.GetComponent<MovementController>().canPoke = false;
            dialogueVisible = true;
            uiCanvas.GetComponent<Canvas>().enabled = true;
            playerObject.GetComponent<MovementController>().enabled = false;
            playerObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            sceneManager.GetComponent<SceneManager>().convoCounter += 1;
            if (sceneManager.GetComponent<SceneManager>().convoCounter <= 7)
            {
                optionManager.GetComponent<OptionManager>().sentenceIndex = 52;
            }
            else if (sceneManager.GetComponent<SceneManager>().convoCounter > 7 && negotiationManager.GetComponent<NegotiationDialogueManager>().retirement == true)
            {
                optionManager.GetComponent<OptionManager>().sentenceIndex = 79;
            }
            else if (sceneManager.GetComponent<SceneManager>().convoCounter > 7 && negotiationManager.GetComponent<NegotiationDialogueManager>().retirement == false)
            {
                optionManager.GetComponent<OptionManager>().sentenceIndex = 80;
            }

            promptPanel.GetComponent<PromptManager>().NextSentence();
            playerObject.GetComponent<Animator>().SetBool("iswalking", false);
            playerObject.GetComponent<Animator>().SetBool("isjumping", false);
            playerObject.GetComponent<Animator>().SetBool("isfalling", false);
            whosTalking = "manager";
            promptText.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
            promptText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(127, 5, 40, 255);
            promptPanel.transform.localPosition = new Vector3(-170, 150, 0);
            optionOne.transform.localPosition = new Vector3(221, -200, 0);
            optionTwo.transform.localPosition = new Vector3(221, 50, 0);
            optionThree.transform.localPosition = new Vector3(221, -75, 0);
            solidarityPanel.transform.localPosition = new Vector3(-250, -235, 0);
            optionManager.GetComponent<OptionManager>().currentSelect = 2;
            mainCamera.GetComponent<CameraManager>().whosFocus = "manager";
            pressCircle.transform.localPosition = new Vector3(-23, 77, 0);
            buttonInstruction.transform.localPosition = new Vector3(290, -200, 0);
        }

    }

    //Audio Voices Management
    private void Update()
    {
        if (promptPanel.GetComponent<PromptManager>().isTyping == true & whosTalking == "wrench")
        {
            if (wrench.GetComponent<AudioSource>().volume < maxVolume)
            {
                wrench.GetComponent<AudioSource>().volume += voxFadeSpeed*Time.deltaTime;
            }
            wrench.GetComponent<Animator>().SetBool("IsTalking", true);
        }
        else if (promptPanel.GetComponent<PromptManager>().isTyping == true & whosTalking == "temp")
        {
            if (temp.GetComponent<AudioSource>().volume < maxVolume)
            {
                temp.GetComponent<AudioSource>().volume += voxFadeSpeed * Time.deltaTime;
            }
            temp.GetComponent<Animator>().SetBool("IsTalking", true);
        }
        else if (promptPanel.GetComponent<PromptManager>().isTyping == true & whosTalking == "welder")
        {
            if (welder.GetComponent<AudioSource>().volume < maxVolume)
            {
                welder.GetComponent<AudioSource>().volume += voxFadeSpeed * Time.deltaTime;
            }
        }
        else if (promptPanel.GetComponent<PromptManager>().isTyping == true & whosTalking == "bigguy")
        {
            if (bigGuy.GetComponent<AudioSource>().volume < maxVolume)
            {
                bigGuy.GetComponent<AudioSource>().volume += voxFadeSpeed * Time.deltaTime;
            }
        }
        else if (promptPanel.GetComponent<PromptManager>().isTyping == true & whosTalking == "data")
        {
            if (data.GetComponent<AudioSource>().volume < maxVolume)
            {
                data.GetComponent<AudioSource>().volume += voxFadeSpeed * Time.deltaTime;
            }
        }
        else if (promptPanel.GetComponent<PromptManager>().isTyping == true & whosTalking == "accounting")
        {
            if (accounting.GetComponent<AudioSource>().volume < maxVolume)
            {
                accounting.GetComponent<AudioSource>().volume += voxFadeSpeed * Time.deltaTime;
            }
            accounting.GetComponent<Animator>().SetBool("IsTalking", true);
        }
        else if (promptPanel.GetComponent<PromptManager>().isTyping == true & whosTalking == "manager")
        {
            if (manager.GetComponent<AudioSource>().volume < maxVolume)
            {
                manager.GetComponent<AudioSource>().volume += voxFadeSpeed * Time.deltaTime;
            }
            manager.GetComponent<Animator>().SetBool("IsTalking", true);
        }
        else if (blackOutManager.GetComponent<BlackOutManager>().isTyping == true)
        {
            if (blackOutManager.GetComponent<AudioSource>().volume < maxVolume)
            {
                blackOutManager.GetComponent<AudioSource>().volume += voxFadeSpeed * Time.deltaTime;
            }
        }
        else
        {
            if (wrench.GetComponent<AudioSource>().volume > zeroVolume)
            {
                wrench.GetComponent<AudioSource>().volume -= voxFadeSpeed * Time.deltaTime;
            }
            if (temp.GetComponent<AudioSource>().volume > zeroVolume)
            {
                temp.GetComponent<AudioSource>().volume -= voxFadeSpeed * Time.deltaTime;
            }
            if (welder.GetComponent<AudioSource>().volume > zeroVolume)
            {
                welder.GetComponent<AudioSource>().volume -= voxFadeSpeed * Time.deltaTime;
            }
            if (bigGuy.GetComponent<AudioSource>().volume > zeroVolume)
            {
                bigGuy.GetComponent<AudioSource>().volume -= voxFadeSpeed * Time.deltaTime;
            }
            if (data.GetComponent<AudioSource>().volume > zeroVolume)
            {
                data.GetComponent<AudioSource>().volume -= voxFadeSpeed * Time.deltaTime;
            }
            if (accounting.GetComponent<AudioSource>().volume > zeroVolume)
            {
                accounting.GetComponent<AudioSource>().volume -= voxFadeSpeed * Time.deltaTime;
            }
            if (manager.GetComponent<AudioSource>().volume > zeroVolume)
            {
                manager.GetComponent<AudioSource>().volume -= voxFadeSpeed * Time.deltaTime;
            }
            if (blackOutManager.GetComponent<AudioSource>().volume > zeroVolume)
            {
                blackOutManager.GetComponent<AudioSource>().volume -= voxFadeSpeed * Time.deltaTime;
            }

            wrench.GetComponent<Animator>().SetBool("IsTalking", false);
            manager.GetComponent<Animator>().SetBool("IsTalking", false);
            temp.GetComponent<Animator>().SetBool("IsTalking", false);
            accounting.GetComponent<Animator>().SetBool("IsTalking", false);
        }

        bool flipBigGuy = (bigGuy.GetComponent<SpriteRenderer>().flipX ? (playerObject.transform.position.x > bigGuy.transform.position.x) : (playerObject.transform.position.x < bigGuy.transform.position.x));

        if (flipBigGuy)
        {
            bigGuy.GetComponent<SpriteRenderer>().flipX = !bigGuy.GetComponent<SpriteRenderer>().flipX;
        }
    }
}