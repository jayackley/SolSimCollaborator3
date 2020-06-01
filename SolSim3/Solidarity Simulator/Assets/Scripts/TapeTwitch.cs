using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapeTwitch : MonoBehaviour {
    public float speed;
    public float yoffset;
    public float xoffset;

	// Use this for initialization
	void Start () {
        StartCoroutine("Twitch");
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    public IEnumerator Twitch()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x+xoffset, gameObject.transform.position.y+yoffset, gameObject.transform.position.z);
        yield return new WaitForSeconds(speed);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x-xoffset, gameObject.transform.position.y-yoffset, gameObject.transform.position.z);
        yield return new WaitForSeconds(speed);
        StartCoroutine("Twitch");
    }


}
