using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAwayManager : MonoBehaviour {

    public Sprite lookCamera;
    public Sprite lookOrb;
    public GameObject negotiationManager;

	
	// Update is called once per frame
	void Update () 
    {
        if (negotiationManager.GetComponent<NegotationSceneManager>().facingCamera == true)
        {
            GetComponent<SpriteRenderer>().sprite = lookCamera;
        }
        if (negotiationManager.GetComponent<NegotationSceneManager>().facingCamera == false)
        {
            GetComponent<SpriteRenderer>().sprite = lookOrb;
        }
    }
}
