using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbHoverManager : MonoBehaviour {


    public bool growing;
    public float speed;
    public float maxScale;
    public float minScale;


	void Start () 
    {
        growing = true;

	}
	
	// Update is called once per frame
	void Update () 
    {

        if (transform.localScale.x < maxScale && growing == true)
        {
            transform.localScale += new Vector3(speed,speed,0);
        }

        if (transform.localScale.x >maxScale && growing == true)
        {
            growing = false;
        }

        if (transform.localScale.x > minScale && growing == false)
        {
            transform.localScale -= new Vector3(speed, speed, 0);
        }

        if (transform.localScale.x <= minScale && growing == false)
        {
            growing = true;
        }

    }
}
