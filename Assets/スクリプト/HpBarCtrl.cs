using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBarCtrl : MonoBehaviour {

    Slider _slider;
    GameObject Enemy;


    void Start()
    {
        // スライダーを取得する
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    float _hp = 0;
    void Update()
    {
        // HP上昇
        _hp += 0.01f;
       

        // HPゲージに値を設定
        _slider.value = _hp;
    }
    public void HPdown()
    {
        _slider.value -= 1f;
    }
}
