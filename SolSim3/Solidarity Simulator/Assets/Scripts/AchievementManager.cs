using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementManager : MonoBehaviour {

    public GameObject playerObject;
    public GameObject promptPanel;
    public GameObject optionManager;


    public GameObject button;
    public GameObject brokeWorkstationBadge;
    public bool brokeWorkstation;

    public bool topclimbtrigger;
    public GameObject topClimb;
    public GameObject topClimbBadge;
    public bool topClimbed;

    public GameObject solidarityObject;
    public GameObject maxSolidarityBadge;
    public bool solidarityMaxed;

    public string patientSoulString;
    public GameObject patientSoulBadge;
    public bool patientSoul;
	

	void Update () 
    {
        if (button.GetComponent<InteractableManager>().pushCount == button.GetComponent<InteractableManager>().pushMax + 2)
        {
            brokeWorkstationBadge.GetComponent<Animator>().SetTrigger("Achieved");
            brokeWorkstation = true;
            button.GetComponent<InteractableManager>().pushCount += 1;
        }
        if (topclimbtrigger == true)
        {
            topClimbBadge.GetComponent<Animator>().SetTrigger("Achieved");
            topClimbed = true;
            topClimb.SetActive(false);
            topclimbtrigger = false;
        }

        if (solidarityObject.GetComponent<SolidarityManager>().solidarity >= 235 && solidarityMaxed == false)
        {
            maxSolidarityBadge.GetComponent<Animator>().SetTrigger("Achieved");
            solidarityMaxed = true;
        }




        if (patientSoulString == "" && playerObject.GetComponent<InteractionManager>().whosTalking == "bigguy" && promptPanel.GetComponent<PromptManager>().isTyping == true)
        {
            patientSoulString = "Maybe...";
        }

        if (playerObject.GetComponent<InteractionManager>().whosTalking == "bigguy" && promptPanel.GetComponent<PromptManager>().isTyping == false && patientSoulString == "Maybe...")
        {
            patientSoulString = "Possibly...";
        }
        if (patientSoulString == "Possibly..." && optionManager.GetComponent<OptionManager>().numberOfOptions == 0 && promptPanel.GetComponent<PromptManager>().isTyping == false)
        {
            patientSoulString = "Achieved";
        }



        if (patientSoulString == "Achieved")
        {
            patientSoulBadge.GetComponent<Animator>().SetTrigger("Achieved");
            patientSoul = true;
        }
    }
    private void OnGUI()
    {
        if (promptPanel.GetComponent<PromptManager>().isTyping == true && (patientSoulString == "Maybe..." || patientSoulString == "Possibly...") && Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space")))
        {
            patientSoulString = "No!";
        }
    }
}
