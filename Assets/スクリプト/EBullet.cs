using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBullet : MonoBehaviour {

    [SerializeField]

    private GameObject bullet;

    private Rigidbody rb;

    float bulletspeed;

    public float speed = 0f;

    public float Des = 0;



    void Start()
    {

        rb = GetComponent<Rigidbody>();

        bulletspeed = 5.0f;

        Destroy(gameObject, 5.0f);

        Invoke("DestroyBullet",Des);

    }

    void Update()
    {

        BulletMove();

    }

    void BulletMove()
    {
        transform.Translate(new Vector3(0f,speed,0));
    }

   

    void DestroyBullet()
    {
        Destroy(this.gameObject);
    }
}
