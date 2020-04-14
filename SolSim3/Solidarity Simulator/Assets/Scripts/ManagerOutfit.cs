using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerOutfit : MonoBehaviour {

    public Sprite officeClothes;
    public Sprite meetingClothes;
    public string wearing;

	void Start () 
    {
        wearing = "office";
	}
	

	void Update () 
    {
		if (wearing == "office")
        {
            GetComponent<SpriteRenderer>().sprite = officeClothes;
        }
        if (wearing == "meeting")
        {
            GetComponent<SpriteRenderer>().sprite = meetingClothes;
        }
	}
}
