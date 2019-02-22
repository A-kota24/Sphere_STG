using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {

	
	void Start () {

        

    }
	
	
	void Update () {
        if (Input.anyKey && !Input.GetMouseButton(0) && !Input.GetMouseButton(1) && !Input.GetMouseButton(2))
        {
            SceneManager.LoadScene("ステージ選択");
        }


    }
}
