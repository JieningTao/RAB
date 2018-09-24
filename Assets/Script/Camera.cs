﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public GameObject Player;
    private Vector3 offest;


	// Use this for initialization
	void Start ()
    {
        offest = transform.position - Player.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Player.transform.position + offest;
	}
}
