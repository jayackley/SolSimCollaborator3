using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScabController : MonoBehaviour {

    public float multiplier;
    public float offset;
    public float bulletSpeed;
    public float aimCone;
    public AudioClip bounce;
    public GameObject solidarityManager;


    private void Start()
    {
        float conePoint = Random.Range(-aimCone, aimCone);
        GetComponent<Rigidbody2D>().velocity = new Vector3(conePoint, - bulletSpeed, 0);
        transform.parent = null;
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
            GameObject.Find("SolidarityCanvas").GetComponent<SolidarityTextManager>().solidarity -= 10;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("bounce");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,bulletSpeed);
        GetComponent<AudioSource>().PlayOneShot(bounce);
    }

}

