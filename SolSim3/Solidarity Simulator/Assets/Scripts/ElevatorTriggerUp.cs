using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorTriggerUp : MonoBehaviour
{
    public GameObject rightElevator;
    public GameObject leftElevator;
    public GameObject middleElevator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (rightElevator.GetComponent<ElevatorManager>().upOrDown == "down")
        {
            rightElevator.transform.position = rightElevator.GetComponent<ElevatorManager>().elevatorTop;
        }
        if (leftElevator.GetComponent<ElevatorManager>().upOrDown == "down")
        {
            leftElevator.transform.position = leftElevator.GetComponent<ElevatorManager>().elevatorTop;
        }
        if (middleElevator.GetComponent<ElevatorManager>().upOrDown == "down")
        {
            middleElevator.transform.position = middleElevator.GetComponent<ElevatorManager>().elevatorTop;
        }
    }
}