using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressPanelManager : MonoBehaviour {

    public GameObject waterCooler;
    public GameObject button;
    public GameObject boardManager;
    public GameObject blackOutManager;
    public GameObject primedIndicator;
    public GameObject optionManager;
    public GameObject strikeInstructionManager;
    public GameObject negotiationDialogueManager;

    private void Start()
    {
        GetComponent<Canvas>().enabled = false;
        primedIndicator.GetComponent<SpriteRenderer>().enabled = false;
    }

    void Update ()
    {
        if (waterCooler.GetComponent<InteractableManager>().primed == true || button.GetComponent<InteractableManager>().primed == true || boardManager.GetComponent<BoardManager>().primed == true || negotiationDialogueManager.GetComponent<NegotiationDialogueManager>().primed == true || blackOutManager.GetComponent<BlackOutManager>().primed == true || optionManager.GetComponent<OptionManager>().primed == true || strikeInstructionManager.GetComponent<StrikeInstructionManager>().primed == true)
        {
            GetComponent<Canvas>().enabled = true;
            primedIndicator.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            GetComponent<Canvas>().enabled = false;
            primedIndicator.GetComponent<SpriteRenderer>().enabled = false;
        }
	}
}
