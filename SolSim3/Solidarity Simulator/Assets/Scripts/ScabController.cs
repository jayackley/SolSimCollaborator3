﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScabController : MonoBehaviour {

    public float multiplier;
    public float offset;
    public float bulletSpeed;
    public float aimCone;
    public AudioClip bounce;


    private void Start()
    {
        float conePoint = Random.Range(-aimCone, aimCone);
        GetComponent<Rigidbody2D>().velocity = new Vector3(conePoint, - bulletSpeed, 0);
        transform.parent = null;
        transform.localScale = new Vector3(0, 0, 1);
    }

    void Update () 
    {
        transform.localScale = new Vector3((transform.position.y+offset)*multiplier, (transform.position.y+offset) * multiplier, 1);
        if (transform.position.y >= 6)
        {
            Destroy(gameObject);
        }
        if (transform.position.y <= -6)
        {
            Destroy(gameObject);
            GameObject.Find("Solidarity").GetComponent<SolidarityManager>().solidarity -= 10;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("bounce");
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, bulletSpeed);
            GetComponent<AudioSource>().PlayOneShot(bounce);
        }
    }

}

