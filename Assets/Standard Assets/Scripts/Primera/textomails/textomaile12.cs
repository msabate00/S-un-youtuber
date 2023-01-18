﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class textomaile12 : MonoBehaviour {
    public GameObject cosa;
    public GameObject textamen;
    public GameObject textamen2;
    public GameObject textamen3;
    public TextMeshProUGUI texto;
    public TextMeshProUGUI texto2;
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    void Start () {
		
	}

    void OnMouseOver()
    {
        if (Statsmails.v12 != 0)
        {
            Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        }
        cosa.SetActive(true);
    }
    void OnMouseExit()
    {
        if (Statsmails.v12 != 0)
        {
            Cursor.SetCursor(null, Vector2.zero, cursorMode);
        }
        cosa.SetActive(false);
    }
    // Update is called once per frame
    void OnMouseDown () {
        if (Statsmails.v12 != 0)
        {
            texto2.text = Statsmails.z12 + ": " + Statsmails.Doce;
            textamen3.SetActive(true);
            texto.text = Statsmails.x12;
            Statsmails.v12 = 2;
            textamen.SetActive(true);
            textamen2.SetActive(true);
        }
    }
}
