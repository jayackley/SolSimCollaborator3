using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementManager : MonoBehaviour {

    public GameObject button;
    public GameObject brokeWorkstationBadge;
    public bool brokeWorkstation;


	

	void Update () 
    {
        if (button.GetComponent<InteractableManager>().pushCount == button.GetComponent<InteractableManager>().pushMax + 2)
        {
            brokeWorkstationBadge.GetComponent<Animator>().SetTrigger("Achieved");
            brokeWorkstation = true;
            button.GetComponent<InteractableManager>().pushMax += 1;
        }
	}
}
