﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Hyperlink : MonoBehaviour {

    public void OnClick()
    {
        Application.ExternalEval("window.open('http://jayackley.com','_blank')");
    }

}
