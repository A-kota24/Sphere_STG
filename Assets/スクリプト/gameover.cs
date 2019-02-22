using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour {

    public GameObject Text;

    private IEnumerator Start () {
        yield return new WaitForSeconds(2.5f);
        Text.SetActive(true);

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Tab))
        {

           SceneManager.LoadScene("Scene1");
        }
		
	}
}
