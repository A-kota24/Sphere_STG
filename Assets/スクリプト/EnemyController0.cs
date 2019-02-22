using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyController0 : MonoBehaviour
{

    public int enemyHP;
    Enemy enemy;
    public GameObject Effect;
    public GameObject Effect1;
    public GameObject Effect2;
    public GameObject Effect3;
    public GameObject Player;
    private MeshRenderer rend;
    private Slider slider;
    public GameObject Text;


    public float a = 50;

    float b = 0;

    float ey;
    float ex;
    bool A = false;

    IEnumerator Start()
    {
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
                this.gameObject.SetActive(false);

            }
        }
    }
    void FixedUpdate()
    {

        if (A == false)
        {
            float x = Random.Range(3, 8.5f);
            float y = Random.Range(-4, 4);

            ex = this.gameObject.transform.position.x;
            ey = this.gameObject.transform.position.y;

            ex = (x - ex) / a;
            ey = (y - ey) / a;

            A = true;


        }
        else
        {
            transform.position = new Vector3(transform.position.x + ex, transform.position.y + ey, 0f);
            b++;
            if (b == a)
            {
                A = false;
                b = 0;
            }

        }

    }
}
