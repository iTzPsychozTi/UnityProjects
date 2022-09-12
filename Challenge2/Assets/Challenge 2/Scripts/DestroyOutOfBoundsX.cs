/*
 * (Kyree Richardson)
 * (Challenge 2)
 * (Manages objects out of bounds)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private HealthSystem healthSystemScript;

    private float leftLimit = -25;
    private float bottomLimit = -10;


    void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag
              ("HealthSystem").GetComponent<HealthSystem>();
    }
    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if out of bounds
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if out of bounds
        else if (transform.position.y < bottomLimit)
        {
            healthSystemScript.TakeDamage();

            Destroy(gameObject);
        }

    }
}
