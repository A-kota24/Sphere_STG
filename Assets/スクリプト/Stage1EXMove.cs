using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1EXMove : MonoBehaviour {

    
    public GameObject Text;
    public GameObject Player;

	void Start () { 
   
	}
	
	
	void Update () {

        int count = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (count == 0)
        {
            Text.SetActive(true);
            Player.SetActive(false);
        }
    }
}
