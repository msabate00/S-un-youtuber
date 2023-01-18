﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comprovador : MonoBehaviour {
    public GameObject yo;
    public static bool derecha = false;
    public static bool izquierda = false;
    public bool desactiva = true;
    public bool desactiva2 = true;
    private int random = 0;
    private int Selector = 0; // Tipos de camara: 1 yo, 2 el, 3 derecha, 4 izquierda.
    int[] tosint = new int[4] { 1, 2, 3, 4 };
    int[] dint = new int[3] { 1, 2, 4 };
    int[] iint = new int[3] { 1, 2, 3 };
    int[] dosint = new int[2] { 1, 2 };
    public Animator polla;
    public GameObject Camaralat;
    public GameObject Camaraman;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (desactiva)
        {
            if (desactiva2)
            {
                if (derecha && izquierda)
                {
                    random = 4;
                    Debug.Log("la ostia");
                    desactiva2 = false;
                    stop();
                    desactiva2 = false;
                }
            }
            if (desactiva2)
            {
                if (derecha)
                {
                    random = 2;
                    Debug.Log("DERECHITA WEY");
                    desactiva2 = false;
                    stop();
                    desactiva2 = false;
                }
            }
                if (desactiva2)
                {
                    if (izquierda)
                    {
                        random = 3;
                        Debug.Log("IZQUIERDITA WEY");
                        desactiva2 = false;
                        stop();
                        desactiva2 = false;
                    }
                }
            if (desactiva2)
            {
                if (!derecha && !izquierda)
                {
                    random = 1;
                    Debug.Log("TE COMES UNA GRAN POLLA");
                    desactiva2 = false;
                    stop();
                    desactiva2 = false;
                }
                }

       }
      // Debug.Log(random);
    }
    void stop()
    {
        if (random == 1){
            int pene = tosint[Random.Range(0, tosint.Length)];
            Debug.Log(pene);
            //   if (pene >= Controlador.Moral && pene <= 100)
            desactiva = false;
            if (pene == 1)
            {
                
                Debug.Log("PUES EL 1 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 1 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 1 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 1 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 1 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Camaralat.SetActive(false);
            }
            if (pene == 2)
            {
                Animaciones.Trigger = true;
                Debug.Log("PUES EL 2 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 2 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 2 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 2 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 2 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Camaralat.SetActive(false);
            }
            if (pene == 3)
            {
                Camaraman.SetActive(false);
                polla.Play("LateralDerecho");
                Debug.Log("PUES EL 3 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 3 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 3 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 3 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 3 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Animaciones.Laterales = true;
            }
            if (pene == 4)
            {
                Camaraman.SetActive(false);
                polla.Play("LateralIzquierdo");
                Debug.Log("PUES EL 4 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 4 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 4 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 4 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 4 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Animaciones.Laterales = true;
            }
        }

        if (random == 2)
        {
            int pene = dint [Random.Range(0, dint.Length)];
            Debug.Log(pene);
            desactiva = false;
            if (pene == 1)
            {
                
                Camaralat.SetActive(false);
                Debug.Log("PUES EL 1 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 1 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 1 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 1 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 1 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
            }
            if (pene == 2)
            {
                Animaciones.Trigger = true;
                Camaralat.SetActive(false);
                Debug.Log("PUES EL 2 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 2 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 2 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 2 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 2 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
            }
            if (pene == 3)
            {
                Camaraman.SetActive(false);
                polla.Play("LateralDerecho");
                Debug.Log("PUES EL 3 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 3 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 3 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 3 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 3 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Animaciones.Laterales = true;
            }
            if (pene == 4)
            {
                Camaraman.SetActive(false);
                polla.Play("LateralIzquierdo");
                Debug.Log("PUES EL 4 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 4 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 4 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 4 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 4 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Animaciones.Laterales = true;
            }
        }
        if (random == 3)
        {
            int pene = iint[Random.Range(0, iint.Length)];
            Debug.Log(pene);
            desactiva = false;
            if (pene == 1)
            {
               
                Camaralat.SetActive(false);
                Debug.Log("PUES EL 1 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 1 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 1 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 1 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 1 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
            }
            if (pene == 2)
            {
                Animaciones.Trigger = true;
                Camaralat.SetActive(false);
                Debug.Log("PUES EL 2 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 2 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 2 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 2 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 2 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
            }
            if (pene == 3)
            {
                Camaraman.SetActive(false);
                polla.Play("LateralDerecho");
                Debug.Log("PUES EL 3 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 3 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 3 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 3 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 3 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Animaciones.Laterales = true;
            }
            if (pene == 4)
            {
                Camaraman.SetActive(false);
                polla.Play("LateralIzquierdo");
                Debug.Log("PUES EL 4 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 4 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 4 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 4 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 4 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Animaciones.Laterales = true;
            }
        }
        if (random == 4)
        {
            int pene = dosint[Random.Range(0, dosint.Length)];
            Debug.Log(pene);
            desactiva = false;
            if (pene == 1)
            {
                
                Camaralat.SetActive(false);
                Debug.Log("PUES EL 1 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 1 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 1 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 1 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 1 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
            }
            if (pene == 2)
            {
                Animaciones.Trigger = true;
                Camaralat.SetActive(false);
                Debug.Log("PUES EL 2 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 2 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 2 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 2 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 2 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
            }
            if (pene == 3)
            {
                Camaraman.SetActive(false);
                polla.Play("LateralDerecho");
                Debug.Log("PUES EL 3 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 3 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 3 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 3 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 3 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Animaciones.Laterales = true;
            }
            if (pene == 4)
            {
                Camaraman.SetActive(false);
                polla.Play("LateralIzquierdo");
                Debug.Log("PUES EL 4 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 4 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 4 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 4 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Debug.Log("PUES EL 4 JODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
                Animaciones.Laterales = true;
            }
        }
    }
}