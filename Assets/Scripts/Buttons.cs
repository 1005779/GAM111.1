﻿using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Play()
    {
        Application.LoadLevel("Level-1");
    }

    public void Main()
    {
        Application.LoadLevel("Main");
    }
}
