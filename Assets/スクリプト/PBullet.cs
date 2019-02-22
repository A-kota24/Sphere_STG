using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBullet : MonoBehaviour
{

    [SerializeField]

    private GameObject bullet;

    private Rigidbody rb;

    float bulletspeed;



    void Start()
    {

        rb = GetComponent<Rigidbody>();

        bulletspeed = 10.0f;

        Destroy(gameObject, 5.0f);

    }

    void Update()
    {

        BulletMove();

    }

    void BulletMove()
    {
        transform.Translate(new Vector3(0.5f, 0, 0));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }

    }
}

