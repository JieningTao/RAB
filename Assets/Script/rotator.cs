﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour {


    public float rotateX;
    public float rotateY;
    public float rotateZ;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(new Vector3(rotateX,rotateY,rotateZ) * Time.deltaTime);
	}
}
