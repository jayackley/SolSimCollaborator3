using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightElevatorTriggerMid : MonoBehaviour
{
    public GameObject rightElevator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (rightElevator.GetComponent<ElevatorRight>().upOrDown == "up" || rightElevator.GetComponent<ElevatorRight>().upOrDown == "down")
        {
            rightElevator.transform.position = rightElevator.GetComponent<ElevatorRight>().elevatorMid;
        }
    }
}