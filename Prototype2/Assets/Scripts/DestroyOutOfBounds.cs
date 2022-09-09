﻿/*
 * (Kyree Richardson)
 * (Prototype 2)
 * (Destroys prefab objects when out of bounds)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;

    private HealthSystem healthSystemScript;

    void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag
            ("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        //if food goes out of bounds
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        //if animals go out of bounds
        if (transform.position.z < bottomBound)
        {
            // Debug.Log("Game Over!");

            //grab the health system script and call takeDamage()
            healthSystemScript.TakeDamage();

            Destroy(gameObject);
        }
    }
}
