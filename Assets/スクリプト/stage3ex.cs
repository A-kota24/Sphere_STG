﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage3ex : MonoBehaviour {

    public GameObject player;

    void Start()
    {


    }

    void Update()
    {

        transform.position = player.transform.position;

    }
}
