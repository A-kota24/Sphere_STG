using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class 悪の根源 : MonoBehaviour {

    MeshCollider MC;
    public Canvas Oonotakashi;

	// Use this for initialization
	void Start () {
        Oonotakashi.enabled = true;
        MC = GetComponent<MeshCollider>();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
