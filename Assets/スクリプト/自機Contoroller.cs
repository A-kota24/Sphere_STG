using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 自機Contoroller : MonoBehaviour {

    float a = 0.08f;
    float b = 0.05f;

    public GameObject Effect;
    public GameObject Effect1;
    public GameObject Effect2;
    public GameObject Effect3;
    public GameObject Effect4;
    public GameObject Effect5;
    public GameObject Effect6;
    public GameObject Effect7;
    public GameObject Text;


    private Vector2 player_pos;

    public void Clamp()
    {
        player_pos = transform.position;

        player_pos.x = Mathf.Clamp(player_pos.x, -8.4f, 8.4f);
        player_pos.y = Mathf.Clamp(player_pos.y, -4.5f, 4.5f);
        transform.position = new Vector2(player_pos.x, player_pos.y);
    }

    void Start () {


	}

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Z))
        {
            a = 0.04f;
            b = 0.03f;

        }

        if (Input.GetKeyUp(KeyCode.Z))
        {

            a = 0.08f;
            b = 0.07f;
        }
        //左矢印を押したとき
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-a, 0f, 0f);

        }

        //右矢印を押したとき
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(a, 0, 0);
        }

        //上矢印を押したとき
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, b, 0);
        }

        //下矢印を押したとき
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -b, 0);
        }

        Clamp();

    }

        public void OnTriggerEnter(Collider other)
        {
        Debug.Log("くそ");
            if (other.gameObject.tag == "EBullet")
            {
            Effect1.SetActive(true);
            Effect2.SetActive(true);
            Effect3.SetActive(true);
            Effect4.SetActive(true);
            Effect5.SetActive(true);
            Effect6.SetActive(true);
            Effect7.SetActive(true);
            Effect.SetActive(true);
            Text.SetActive(true);
            Destroy(gameObject);
            }

        if (other.gameObject.tag == "Enemy")
        {
            Effect.SetActive(true);
            Effect1.SetActive(true);
            Effect2.SetActive(true);
            Effect3.SetActive(true);
            Effect4.SetActive(true);
            Effect5.SetActive(true);
            Effect6.SetActive(true);
            Effect7.SetActive(true);
            Text.SetActive(true);
            Destroy(gameObject);
        }
        }

  


}
