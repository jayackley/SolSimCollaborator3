using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorManager : MonoBehaviour {

    public Vector3 elevatorTop;
    public Vector3 elevatorBottom;
    public GameObject walls;
    public string upOrDown;
    public float speed;
    public bool goingUp;
    public bool goingDown;
    public GameObject playerObject;

	void Start () 
    {
        upOrDown = "up";
        transform.position = elevatorTop;
        goingDown = true;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision is CapsuleCollider2D && upOrDown == "down")
        {
            StartCoroutine("Elevate");
            upOrDown = "";
            walls.SetActive(true);
        }
        else if (collision is CapsuleCollider2D && upOrDown == "up")
        {
            StartCoroutine("Delevate");
            upOrDown = "";
            walls.SetActive(true);
        }


    }
    // Update is called once per frame
    void Update () 
    {

        if (transform.position.y > (elevatorTop.y-0.1))
        {
            goingUp = false;
            upOrDown = "up";
        }
        if (transform.position.y < (elevatorBottom.y + 0.1))
        {
            goingDown = false;
            upOrDown = "down";
        }
    }

    private void FixedUpdate()
    {
        if (goingUp == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, elevatorTop, speed * Time.deltaTime);
        }
        if (goingDown == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, elevatorBottom, speed * Time.deltaTime);
        }
    }

    public IEnumerator Elevate()
    {
        yield return new WaitForSeconds(Random.Range(.4f, .6f));
        playerObject.transform.parent = transform;
        goingUp = true;
        yield return new WaitForSeconds(speed);
        walls.SetActive(false);
        playerObject.transform.parent = null;
    }
    public IEnumerator Delevate()
    {
        yield return new WaitForSeconds(Random.Range(.4f, .6f));
        playerObject.transform.parent = transform;
        goingDown = true;
        yield return new WaitForSeconds(speed);
        walls.SetActive(false);
        playerObject.transform.parent = null;
    }
}
