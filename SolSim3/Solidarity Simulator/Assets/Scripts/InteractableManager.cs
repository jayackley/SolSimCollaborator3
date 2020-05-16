using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableManager : MonoBehaviour {

    public GameObject rightElevator;
    public GameObject buttonInstruction;
    public bool primed;
    public GameObject pressCircle;
    public GameObject uiPressCircle;
    public GameObject signTextManager;
    public float waitTime;
    public AudioSource soundholder;
    public AudioClip sound;
    public int pushMax;
    public int pushCount;


    public void Start()
    {
        primed = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision is BoxCollider2D && collision.gameObject.name == "PlayerObject")
        {
            primed = true;
        }
    }

    private void OnTriggerExit2D()
    {
        primed = false;
    }

    public void Update()
    {
        if (primed)
        {
            pressCircle.SetActive(true);
        }
        else{
            pressCircle.SetActive(false);
        }
    }

    public void Pour()
    {
        if (buttonInstruction.activeSelf == true && primed == true)
        {
            buttonInstruction.SetActive(false);
            uiPressCircle.SetActive(false);
        }
        if (primed == true & pushCount <= pushMax)
        {
            GetComponent<Animator>().SetTrigger("pour");
            GetComponent<BoxCollider2D>().enabled = false;
            soundholder.PlayOneShot(sound);
            StartCoroutine("Wait");
            pushCount += 1;
            //signTextManager.GetComponent<SignTextManger>().buttonIndex += 1;
            //signTextManager.GetComponent<SignTextManger>().ButtonNextSentence();
        }
        if (primed = true & pushCount ==(pushMax+1))
        {
            GetComponent<Animator>().SetTrigger("break");
            primed = false;
            GetComponent<BoxCollider2D>().enabled = false;
            pressCircle.SetActive(false);
            soundholder.pitch -= 0.5f;
            soundholder.PlayOneShot(sound);
            pushCount += 1;
            gameObject.GetComponent<InteractableManager>().enabled = false;
            //signTextManager.GetComponent<SignTextManger>().buttonIndex += 1;
            //signTextManager.GetComponent<SignTextManger>().ButtonNextSentence();

        }

    }
    public void TriggerElevator()
    {
        if (rightElevator.GetComponent<ElevatorManager>().upOrDown=="down")
        {
            rightElevator.GetComponent<ElevatorManager>().goingUp = true;
        }
        if (rightElevator.GetComponent<ElevatorManager>().upOrDown == "up")
        {
            rightElevator.GetComponent<ElevatorManager>().goingDown = true;
        }
    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);
        if (pushCount <= pushMax)
        { 
        GetComponent<BoxCollider2D>().enabled = true;
    }
    }


}
