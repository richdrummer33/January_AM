﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int richardsInteger = 6; // 0 by default unless otherwise stated (e.g. = 6)

    float myFloat;

    string mySting;

    public Transform myTransform; // Empty bucket that holds a "Transform" component

    public float speed; // in meters per second

    // Start is called before the first frame update
    void Start()
    {
        RichardsMethod();

        richardsInteger = 12; //
    }

    // Update is called once per frame
    void Update()
    {
        richardsInteger = richardsInteger + 1;

        if (Input.GetKey(KeyCode.W)) // Forward
        {
            myTransform.position = myTransform.position + transform.forward * Time.deltaTime * speed; // Move 1 meter every frame
        }
        else if (Input.GetKey(KeyCode.S)) // Back
        {
            myTransform.position = myTransform.position - transform.forward * Time.deltaTime * speed;
        }
        else if (Input.GetKey(KeyCode.A)) // Left
        {
            myTransform.position = myTransform.position - transform.right * Time.deltaTime * speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            myTransform.position = myTransform.position + transform.right * Time.deltaTime * speed;
        }

        // Add another 2 conditions (else if statement) for moving up and down
    }

    void RichardsMethod()
    {
        // Write my code
    }
}
