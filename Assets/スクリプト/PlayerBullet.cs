using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour {

    [SerializeField]

    private GameObject bullet;

    bool A = true;

    public float shotdelay = 0;

	void Start () {
		
	}
	
	void Update () {
        if (A == true) {

            ShotAction();
        }
        else
        {
            return;
        }

        
		
	}

    void ShotAction()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, transform.rotation);
            A = false;
            Invoke("AFlag",shotdelay);
        }
    }

    void AFlag()
    {
        A = true;
    }
}
