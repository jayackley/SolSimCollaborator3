using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfSpinner : MonoBehaviour {

    public float speed;
    public float degree;


    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(Vector3.forward * degree);
        degree += speed;
    }

}
