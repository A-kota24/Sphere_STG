using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1EX : MonoBehaviour {

    public float w = 0f;
    public GameObject Text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (w == 2)
        {
            Text.SetActive(true);
        }
	}
}
