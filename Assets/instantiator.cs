﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    // Start is called before the first frame update
    void Start()
    {
        int counter = 0;
        while (counter < 3) {
            Instantiate(objectToClone);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
