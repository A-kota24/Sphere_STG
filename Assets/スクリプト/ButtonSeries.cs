using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSeries : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StageSelect()
    {
        SceneManager.LoadScene("ステージ選択");
    }

    public void Stage1()
    {
        SceneManager.LoadScene("ステージ１");
    }
    public void Stage1EX()
    {
        SceneManager.LoadScene("ステージ１EX");
    }

    public void Stage2()
    {
        SceneManager.LoadScene("ステージ２");
    }
    public void Stage2EX()
    {
        SceneManager.LoadScene("ステージ２EX");
    }
    public void Stage3()
    {
        SceneManager.LoadScene("ステージ３");
    }
    public void Stage3EX()
    {
        SceneManager.LoadScene("ステージ３EX");
    }
    public void Key()
    {
        SceneManager.LoadScene("操作説明");
    }
}
