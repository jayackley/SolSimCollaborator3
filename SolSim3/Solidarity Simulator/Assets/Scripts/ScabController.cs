using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScabController : MonoBehaviour {

    public float multiplier;
    public float offset;
    public float bulletSpeed;
    public float aimCone;


    private void Start()
    {
        float conePoint = Random.Range(-aimCone, aimCone);
        GetComponent<Rigidbody2D>().velocity = new Vector3(conePoint, - bulletSpeed, 0);
        transform.parent = null;
    }

    void Update () 
    {
        transform.localScale = new Vector3((transform.position.y+offset)*multiplier, (transform.position.y+offset) * multiplier, 1);
	}
    private void OnCollisionEnter2D()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up);
    }

}

