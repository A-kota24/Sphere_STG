using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyContoroller2 : MonoBehaviour
{
    public int enemyHP;
    Enemy enemy;
    public float x;
    public float z;
    float y;
    public float sp = 0.015f;
    public GameObject Effect;
    public GameObject Effect1;
    public GameObject Effect2;
    public GameObject Effect3;
    public GameObject Text;
    Animation anim;
    private Slider slider;
    public GameObject Player;

    IEnumerator Start()
    {
        anim = GetComponent<Animation>();
        enemy = GetComponent<Enemy>();
        slider = GameObject.Find("EnemyHPSlider").GetComponent<Slider>();
        slider.maxValue = enemyHP;
        slider.value = enemyHP;

        while (true)
        {

            // 子要素を全て取得する
            for (int i = 0; i < transform.childCount; i++)
            {

                Transform Shotposition = transform.GetChild(i);

                // Shotpositionの位置/角度で弾を撃つ
                this.enemy.Shot(Shotposition);
            }

            // shotDelay秒待つ
            yield return new WaitForSeconds(enemy.shotDelay);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("PlayerBullet"))
        { 
            enemyHP -= 1;
            slider.value = enemyHP;

            if (enemyHP == 0)
            {
                Effect.SetActive(true);
                Effect1.SetActive(true);
                Effect2.SetActive(true);
                Effect3.SetActive(true);
                Text.SetActive(true);
                Player.SetActive(false);
                Destroy(this.gameObject);
            }
        }

    }
    

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(x, 0, z);

        transform.Translate(0, sp, 0, Space.World);
        y = transform.position.y;
        if (y > 3.1f || y < -3.1f)
        {
            sp *= -1;
        }

    }
}
    
