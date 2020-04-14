using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScabSpawnManager : MonoBehaviour {

    public GameObject scabBot;
    public GameObject target;

    private void OnGUI()
    {
        if(Event.current.Equals(Event.KeyboardEvent("s")))
        {
            ShootScab();
        }
    }

    void ShootScab()
    {
        Instantiate(scabBot,transform);
    }

}
