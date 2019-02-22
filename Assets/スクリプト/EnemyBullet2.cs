using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet2 : MonoBehaviour {

    public Transform target;

    public float ab = 0f;
    public float Delay = 0f;
    public float Tama = 0;
    public float ang = 0;

    [SerializeField]

    private GameObject bullet;
    bool TKS = true;

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        //transform.rotation = Quaternion.AngleAxis(ang, new Vector3(1,0,0));
        if (TKS)
        {
            //transform.LookAt(target);
            Invoke("Shot", 0.1f);
            TKS = false;
        }

    }

    private void Shot()
    {
        Instantiate(bullet, transform.position, transform.rotation);
        ab+= 1;
        if (ab >= Tama)
        {
            BulletDelay();
        }
        else
        {
            TKS = true;
        }
        
        return;
    }
    private void BulletDelay()
    {
        ab = 0f;
        Invoke("Shot", Delay);

    }

}
