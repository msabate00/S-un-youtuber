﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desactivarlukat : MonoBehaviour {
    public GameObject yo;
    public GameObject yo2;
    public Camera camaritawey;
    public Camera camaritawey2;
    public GameObject camaraman;
    public GameObject camaraman2;
    public float pene;
	void OnEnable () {
		Invoke("alamierda", pene);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

void alamierda()
    {
        camaraman.SetActive (true);
        camaritawey.enabled = true;
        camaritawey2.enabled = true;
        camaraman.GetComponent<FUCKMIERDA>().enabled = true;
        camaraman2.GetComponent<FUCKMIERDA>().enabled = true;
        Debug.Log("A la mierda");
        yo.GetComponent<lukat1>().enabled = false;
        yo2.GetComponent<Salto4>().enabled = true;
    }


}
