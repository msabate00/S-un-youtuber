﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muevete3 : MonoBehaviour {
    public GameObject yo;
    public Rigidbody rb;
    [RangeAttribute(-7.0f, 0.0f)]
    public float pene = 1;

    void Update()
    {
      //  Vector3 movement = new Vector3(pene * Time.deltaTime, 0);
        //rb.MovePosition(transform.position + movement);
       transform.position += transform.right * pene *Time.deltaTime;


    }

}