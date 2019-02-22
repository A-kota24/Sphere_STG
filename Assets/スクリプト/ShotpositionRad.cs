using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotpositionRad : MonoBehaviour {

    public float z;
    public float y;

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update() {

        this.gameObject.transform.Rotate(0,y,z);
	}
}
