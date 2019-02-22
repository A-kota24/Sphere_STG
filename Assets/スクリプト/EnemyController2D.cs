using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController2D : MonoBehaviour
{ public float sp = 0.015f;
    float y;
    float x;
    float z;

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
