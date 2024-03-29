﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagneticFeild : MonoBehaviour
{
    [SerializeField]
    GameObject Magnet;
    [SerializeField]
    float forceFactor = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce((Magnet.transform.position - transform.position)
            * forceFactor * Time.smoothDeltaTime);
    }
}
