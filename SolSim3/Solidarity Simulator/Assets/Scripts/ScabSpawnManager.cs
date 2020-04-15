using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScabSpawnManager : MonoBehaviour {

    public GameObject scabBot;
    public GameObject target;
    public AudioClip shoot;

    private void OnGUI()
    {
        if(Event.current.Equals(Event.KeyboardEvent("s")))
        {
            ShootScab();
            GetComponent<AudioSource>().PlayOneShot(shoot);
        }
    }

    void ShootScab()
    {
        Instantiate(scabBot,transform);
    }

}
