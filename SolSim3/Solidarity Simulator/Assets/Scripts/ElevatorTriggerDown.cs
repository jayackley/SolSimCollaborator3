using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorTriggerDown : MonoBehaviour
{
    public GameObject leftElevator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (leftElevator.GetComponent<ElevatorManager>().upOrDown == "up")
        {
            leftElevator.GetComponent<ElevatorManager>().goingDown = true;
            leftElevator.GetComponent<ElevatorManager>().upOrDown = "";
        }
    }
}