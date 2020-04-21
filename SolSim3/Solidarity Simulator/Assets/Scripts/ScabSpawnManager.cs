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
    public int howManyShot;
    public int shotLimit;
    public GameObject strikeInstructionManager;
    public GameObject sceneManager;


    private void Start()
    {
    }

    private void OnGUI()
    {
        /*
        if(Event.current.Equals(Event.KeyboardEvent("s")))
        {
            ShootScab();
        }
        */
    }

    public void Update()
    {
        if (howManyShot == shotLimit)
        {
            strikeInstructionManager.SetActive(true);
            strikeInstructionManager.GetComponent<StrikeInstructionManager>().index = 5;
            strikeInstructionManager.GetComponent<StrikeInstructionManager>().NextSentence();
            gameObject.SetActive(false);
            GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("Scab");
            foreach (GameObject go in gameObjectArray)
            {
                go.GetComponent<Rigidbody2D>().velocity = new Vector2(0, go.GetComponent<ScabController>().bulletSpeed); 
            }
        }
    }

    public void ShootScab()
    {
        if(shootWait >= minWait)
        {
            Instantiate(scabBot, transform);
            GetComponent<AudioSource>().PlayOneShot(shoot);
            shootWait -= speedUpAmount;
            howManyShot += 1;
            StartCoroutine(Wait());
        }
        else
        {
            Instantiate(scabBot, transform);
            GetComponent<AudioSource>().PlayOneShot(shoot);
            howManyShot += 1;
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(shootWait);
        ShootScab();
    }

}
