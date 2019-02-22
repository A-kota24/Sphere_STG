using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCotrollersub : MonoBehaviour {

    public float rot;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(transform.up, rot);
    }
}
