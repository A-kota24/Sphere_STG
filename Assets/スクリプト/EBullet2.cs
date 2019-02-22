using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EBullet2 : MonoBehaviour {

    [SerializeField]

    private GameObject bullet;

    private Rigidbody rb;
    

    public float Des = 0;
    public float speed;
    public Transform target;
    public float move;



    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        //transform.LookAt(target);

        Invoke("DestroyBullet", Des);

    }

    void Update()
    {
        transform.Translate(0, 0, move, Space.Self);
        
        //rb.AddForce(speed, 0, 0);
    }




    void DestroyBullet()
    {
        Destroy(this.gameObject);
    }
}
