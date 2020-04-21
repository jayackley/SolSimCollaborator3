using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SolidarityManager : MonoBehaviour {

    public int solidarity;
    public TextMeshProUGUI textDisplay;
    public bool leverage;

    // Use this for initialization
    void Start () {

        textDisplay.GetComponent<TextMeshProUGUI>().color = new Color32(255, 255, 255, 255);
        textDisplay.GetComponent<TextMeshProUGUI>().faceColor = new Color32(0, 255, 128, 255);
    }
	
	// Update is called once per frame
	void Update () 
    {
        if(leverage == false)
        {
            textDisplay.text = "Solidarity: " + solidarity;
        }
        if (leverage == true)
        {
            textDisplay.text = "Leverage: " + solidarity;
        }
    }
}
