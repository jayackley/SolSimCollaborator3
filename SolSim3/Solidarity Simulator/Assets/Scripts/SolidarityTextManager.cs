using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SolidarityTextManager : MonoBehaviour {

    public int solidarity;
    public GameObject solidarityText;

	void Start ()
    {
		
	}
	

	void Update () 
    {
        solidarityText.GetComponent<TextMeshProUGUI>().text = "Solidarity: " + solidarity;
	}
}
