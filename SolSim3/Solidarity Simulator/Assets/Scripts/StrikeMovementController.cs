using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikeMovementController : MonoBehaviour 
{

    public float moveSpeed = 10f;
    private Rigidbody2D rigidbody2d;
    public GameObject solidarityManager;
    public Animation strikeAttrition;

    // Use this for initialization
    void Start () 
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rigidbody2d.velocity = new Vector2(+moveSpeed, rigidbody2d.velocity.y);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rigidbody2d.velocity = new Vector2(-moveSpeed, rigidbody2d.velocity.y);
        }
        else
        {
            rigidbody2d.velocity = new Vector2(0, rigidbody2d.velocity.y);
        }

        if (solidarityManager.GetComponent<SolidarityManager>().solidarity >= 110)
        {
            GetComponent<Animator>().Play("StrikeAttrition", 0, 0f);
        }
        else if (solidarityManager.GetComponent<SolidarityManager>().solidarity >= 90 && solidarityManager.GetComponent<SolidarityManager>().solidarity < 110)
        {
            GetComponent<Animator>().Play("StrikeAttrition", 0, 0.1429f);
        }
        else if (solidarityManager.GetComponent<SolidarityManager>().solidarity >= 70 && solidarityManager.GetComponent<SolidarityManager>().solidarity < 90)
        {
            GetComponent<Animator>().Play("StrikeAttrition", 0, 0.2858f);
        }
        else if (solidarityManager.GetComponent<SolidarityManager>().solidarity >= 50 && solidarityManager.GetComponent<SolidarityManager>().solidarity < 70)
        {
            GetComponent<Animator>().Play("StrikeAttrition", 0, 0.4287f);
        }
        else if (solidarityManager.GetComponent<SolidarityManager>().solidarity >= 30 && solidarityManager.GetComponent<SolidarityManager>().solidarity < 50)
        {
            GetComponent<Animator>().Play("StrikeAttrition", 0, 0.5715f);
        }
        else if (solidarityManager.GetComponent<SolidarityManager>().solidarity >= 20 && solidarityManager.GetComponent<SolidarityManager>().solidarity < 30)
        {
            GetComponent<Animator>().Play("StrikeAttrition", 0, 0.7143f);
        }
        else if (solidarityManager.GetComponent<SolidarityManager>().solidarity >= 10 && solidarityManager.GetComponent<SolidarityManager>().solidarity < 20)
        {
            GetComponent<Animator>().Play("StrikeAttrition", 0, 0.8572f);
        }
        else if (solidarityManager.GetComponent<SolidarityManager>().solidarity >= 0 && solidarityManager.GetComponent<SolidarityManager>().solidarity < 10)
        {
            GetComponent<Animator>().Play("StrikeAttrition", 0, .99f);
        }
    }
}
