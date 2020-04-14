using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverManager : MonoBehaviour {

    public GameObject hoverOne;
    public GameObject hoverTwo;

	
	// Update is called once per frame
	void Update () 
    {
        transform.position = (hoverOne.GetComponent<Transform>().position + hoverTwo.GetComponent<Transform>().position) / 2;
    }
}
