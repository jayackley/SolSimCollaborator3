using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DirectorySignManager : MonoBehaviour {

    public TextMeshProUGUI wrenchText;
    public TextMeshProUGUI tempText;
    public TextMeshProUGUI welderText;
    public TextMeshProUGUI bigGuyText;
    public TextMeshProUGUI dataText;
    public TextMeshProUGUI accountingText;
    public TextMeshProUGUI managerText;
    public GameObject wrench;
    public GameObject temp;
    public GameObject welder;
    public GameObject bigGuy;
    public GameObject data;
    public GameObject accounting;
    public GameObject manager;


	// Use this for initialization
	void Start () 
    {
        wrenchText.faceColor = new Color32(255, 0, 0, 255);
        tempText.faceColor = new Color32(255, 0, 0, 255);
        welderText.faceColor = new Color32(255, 0, 0, 255);
        bigGuyText.faceColor = new Color32(255, 0, 0, 255);
        dataText.faceColor = new Color32(255, 0, 0, 255);
        accountingText.faceColor = new Color32(255, 0, 0, 255);
        managerText.faceColor = new Color32(255, 0, 0, 255);
    }
	
	// Update is called once per frame
	void Update () 
    {
		if (wrench.GetComponent<CapsuleCollider2D>().enabled == false)
        {
            wrenchText.faceColor = new Color32(200, 200, 200, 255);
            wrenchText.GetComponentInChildren<SpriteRenderer>().color = new Color32(200, 200, 200, 70);
        }
        if (temp.GetComponent<CapsuleCollider2D>().enabled == false)
        {
            tempText.faceColor = new Color32(200, 200, 200, 255);
            tempText.GetComponentInChildren<SpriteRenderer>().color = new Color32(200, 200, 200, 70);
        }
        if (welder.GetComponent<CapsuleCollider2D>().enabled == false)
        {
            welderText.faceColor = new Color32(200, 200, 200, 255);
            welderText.GetComponentInChildren<SpriteRenderer>().color = new Color32(200, 200, 200, 70);
        }
        if (bigGuy.GetComponent<CapsuleCollider2D>().enabled == false)
        {
            bigGuyText.faceColor = new Color32(200, 200, 200, 255);
            bigGuyText.GetComponentInChildren<SpriteRenderer>().color = new Color32(200, 200, 200, 70);
        }
        if (data.GetComponent<CapsuleCollider2D>().enabled == false)
        {
            dataText.faceColor = new Color32(200, 200, 200, 255);
            dataText.GetComponentInChildren<SpriteRenderer>().color = new Color32(200, 200, 200, 70);
        }
        if (accounting.GetComponent<CapsuleCollider2D>().enabled == false)
        {
            accountingText.faceColor = new Color32(200, 200, 200, 255);
            accountingText.GetComponentInChildren<SpriteRenderer>().color = new Color32(200, 200, 200, 70);
        }
        if (manager.GetComponent<CapsuleCollider2D>().enabled == false)
        {
            managerText.faceColor = new Color32(200, 200, 200, 255);
            managerText.GetComponentInChildren<SpriteRenderer>().color = new Color32(200, 200, 200, 70);
        }
    }
}
