﻿using UnityEngine;
using System.Collections;

public class MyNewScript : MonoBehaviour 
{
	public string PlayerName = "";
	public int PlayerHealth = 100;
	public Vector3 Position = Vector3.zero;

	// Use this for initialization
	void Start () {
		Debug.Log(PlayerName);
        Debug.Log(PlayerHealth);
        Debug.Log("Position : " + transform.position);
    }
	// Update is called once per frame
	void Update () {}
}