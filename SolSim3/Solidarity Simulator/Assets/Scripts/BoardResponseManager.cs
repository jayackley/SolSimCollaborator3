using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoardResponseManager : MonoBehaviour {

    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    public GameObject boardPanel;

    private void Start()
    {
        textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255,255,255,255);
        textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(0, 255, 128, 255);
    }

    void Update()
    {
        textDisplay.text = sentences[boardPanel.GetComponent<NegotiationDialogueManager>().index];
    }

}
