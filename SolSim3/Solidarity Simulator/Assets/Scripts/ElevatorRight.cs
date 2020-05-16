using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorRight : MonoBehaviour {

    public Vector3 elevatorTop;
    public Vector3 elevatorMid;
    public Vector3 elevatorBottom;
    public GameObject walls;
    public string upOrDown;
    public float speed;
    public bool goingUp;
    public bool goingDown;
    public string lastStop;
    public GameObject playerObject;

    void Start()
    {
        upOrDown = "up";
        transform.position = elevatorTop;
        goingDown = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(upOrDown);
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
        else if (collision is CapsuleCollider2D && upOrDown == "mid")
        {
            if(lastStop == "down")
            {
                StartCoroutine("Elevate");
                upOrDown = "";
                walls.SetActive(true);
            }
            else if (lastStop == "up")
            {
                StartCoroutine("Delevate");
                upOrDown = "";
                walls.SetActive(true);
            }
        }

        //make it so it doesn't bounce in elevators
        /*
        if (collision is CapsuleCollider2D && collision.transform.tag == "Player")
        {
            collision.transform.parent = transform;
            playerObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.transform.parent = null;
            playerObject.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
*/
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > (elevatorTop.y - 0.1))
        {
            goingUp = false;
            upOrDown = "up";
            lastStop = "up";
        }
        if (transform.position.y < (elevatorBottom.y + 0.1))
        {
            goingDown = false;
            upOrDown = "down";
            lastStop = "down";
        }
        if (transform.position.y == elevatorMid.y)
        {
            goingDown = false;
            goingUp = false;
            upOrDown = "mid";
        }
    }

    void FixedUpdate()
    {
        if (upOrDown == "down" && goingUp == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, elevatorMid, speed * Time.deltaTime);
        }
        if (upOrDown == "mid" && goingUp == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, elevatorTop, speed * Time.deltaTime);
        }
        if (upOrDown == "up" && goingDown == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, elevatorMid, speed * Time.deltaTime);
        }
        if (upOrDown == "mid" && goingDown == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, elevatorBottom, speed * Time.deltaTime);
        }
    }

    public IEnumerator Elevate()
    {
        yield return new WaitForSeconds(Random.Range(.5f, 1.5f));
        goingUp = true;
        Debug.Log("going up");
        yield return new WaitForSeconds(speed);
        walls.SetActive(false);
    }
    public IEnumerator Delevate()
    {
        yield return new WaitForSeconds(Random.Range(.5f, 1.5f));
        goingDown = true;
        Debug.Log("going down");
        yield return new WaitForSeconds(speed);
        walls.SetActive(false);
    }
}