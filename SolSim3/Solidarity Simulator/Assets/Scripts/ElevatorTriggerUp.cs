using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorTriggerUp : MonoBehaviour
{
    public GameObject leftElevator;
    public GameObject middleElevator;
    public GameObject rightElevator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (leftElevator.GetComponent<ElevatorManager>().upOrDown == "down")
        {
            leftElevator.transform.position = leftElevator.GetComponent<ElevatorManager>().elevatorTop;
        }
        if (middleElevator.GetComponent<ElevatorManager>().upOrDown == "down")
        {
            middleElevator.transform.position = middleElevator.GetComponent<ElevatorManager>().elevatorTop;
        }
        if (rightElevator.GetComponent<ElevatorRight>().upOrDown == "down" || rightElevator.GetComponent<ElevatorRight>().upOrDown == "mid")
        {
            rightElevator.transform.position = rightElevator.GetComponent<ElevatorRight>().elevatorTop;
        }
    }
}