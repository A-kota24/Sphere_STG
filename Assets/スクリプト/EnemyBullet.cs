using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

    [SerializeField]

    private GameObject bullet;
    bool TKS = true;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (TKS)
        {
            Invoke("Shot", 0.8f);
            TKS = false;
        }
		
	}

    private void Shot()
    {
        Instantiate(bullet, transform.position, transform.rotation);
        TKS = true;
        return;
    }

    
}
