using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCDown : MonoBehaviour {

    public GameObject StartText1;
    public GameObject StartText2;
    public GameObject Player;
    public GameObject Enemy;
    public GameObject Enemy2;
    public GameObject ex;

    // Use this for initialization
    private IEnumerator Start() {
        StartText1.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        StartText2.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        Player.SetActive(true);
        Enemy.SetActive(true);
        Enemy2.SetActive(true);
        ex.SetActive(true);

		
	}
	
	// Update is called once per frame
	void Update () {


    }
}
