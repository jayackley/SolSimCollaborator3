﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMiddleTriggerDown : MonoBehaviour
{
    public GameObject middleElevator;
    public GameObject rightElevator;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (middleElevator.GetComponent<ElevatorManager>().upOrDown == "up")
        {
            middleElevator.transform.position = middleElevator.GetComponent<ElevatorManager>().elevatorBottom;
        }
        if (rightElevator.GetComponent<ElevatorRight>().upOrDown == "up" || rightElevator.GetComponent<ElevatorRight>().upOrDown == "mid")
        {
            rightElevator.transform.position = rightElevator.GetComponent<ElevatorRight>().elevatorBottom;
        }
    }
}