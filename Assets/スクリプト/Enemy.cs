using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    int a = 0;

    public float speed;

    public float shotDelay;

    public GameObject bullet;

    public bool canShot;

    public void Shot(Transform origin)
    {
        Vector3 tmp = GameObject.Find("ShotPosition").transform.position;


    }

    void Start() {

    }

    void Update() {

        transform.Translate(new Vector3(-0.03f, 0f, 0f));

    }
    

    
    }
