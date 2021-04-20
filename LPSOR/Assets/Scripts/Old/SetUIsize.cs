﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUIsize : MonoBehaviour
{
    public Camera cam;

    float quotient;
    float camsize;

    void Start()
    {
        float defsize = transform.localScale.x;
        camsize = cam.orthographicSize;

        quotient = defsize / camsize;
    }
   
    void Update()
    {
        camsize = cam.orthographicSize;
        transform.localScale = new Vector3(camsize * quotient, camsize * quotient,0);
    }
}
