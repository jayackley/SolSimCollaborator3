using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AccountingNumbersManager : MonoBehaviour {

    public TextMeshProUGUI numbers;
    public float typingSpeed;
    public char c;

	// Use this for initialization
	void Start () 
    {
        StartCoroutine(SafetyType());
	}


    IEnumerator SafetyType()
    {
        c = "01*10+^$#      "[Random.Range(0, 15)];
        numbers.text += c;
        yield return new WaitForSeconds(typingSpeed);
        numbers.text = numbers.text.Substring(1);
        StartCoroutine(SafetyType());
    }

}
