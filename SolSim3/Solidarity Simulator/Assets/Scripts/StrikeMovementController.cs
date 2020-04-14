using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikeMovementController : MonoBehaviour 
{

    public float moveSpeed = 10f;
    private Rigidbody2D rigidbody2d;

    // Use this for initialization
    void Start () {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rigidbody2d.velocity = new Vector2(+moveSpeed, rigidbody2d.velocity.y);
            //footSteps = true;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rigidbody2d.velocity = new Vector2(-moveSpeed, rigidbody2d.velocity.y);
            //footSteps = true;
        }
        else
        {
            rigidbody2d.velocity = new Vector2(0, rigidbody2d.velocity.y);
        }
    }
}
