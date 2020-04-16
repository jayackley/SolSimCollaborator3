using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScabSpawnManager : MonoBehaviour {

    public GameObject scabBot;
    public GameObject target;
    public AudioClip shoot;
    public float shootWait;
    public float minWait;
    public float speedUpAmount;

    private void Start()
    {
        ShootScab();
    }

    private void OnGUI()
    {
        if(Event.current.Equals(Event.KeyboardEvent("s")))
        {
            ShootScab();
        }
    }

    void ShootScab()
    {
        if(shootWait >= minWait)
        {
            Instantiate(scabBot, transform);
            GetComponent<AudioSource>().PlayOneShot(shoot);
            shootWait -= speedUpAmount;
            StartCoroutine(Wait());
        }
        else
        {
            Instantiate(scabBot, transform);
            GetComponent<AudioSource>().PlayOneShot(shoot);
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(shootWait);
        ShootScab();
    }

}
