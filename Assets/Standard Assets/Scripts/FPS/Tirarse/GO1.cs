﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO1 : MonoBehaviour {

    public GameObject spawn;
    public static bool Dale;
    public float pene;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Dale)
        {
            spawn.GetComponent<Teleport5>().enabled = true;
            Debug.Log("OH wow");
            Destroy(gameObject, pene);
        }
     }
}
