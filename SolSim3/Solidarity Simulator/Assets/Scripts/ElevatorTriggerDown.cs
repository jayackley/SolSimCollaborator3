using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorTriggerDown : MonoBehaviour
{
    public GameObject rightElevator;
    public GameObject leftElevator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (rightElevator.GetComponent<ElevatorManager>().upOrDown == "up")
        {
            rightElevator.GetComponent<ElevatorManager>().goingDown = true;
            rightElevator.GetComponent<ElevatorManager>().upOrDown = "";

        }
        if (leftElevator.GetComponent<ElevatorManager>().upOrDown == "up")
        {
            leftElevator.GetComponent<ElevatorManager>().goingDown = true;
            leftElevator.GetComponent<ElevatorManager>().upOrDown = "";
        }
    }
}