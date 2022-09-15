﻿/* Kyree Richardson
 * Challenge 3
 * (Spins objects)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObjectsX : MonoBehaviour
{
    public float spinSpeed;

    private PlayerControllerX playerControllerScript;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }


    // Update is called once per frame
    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
        }
    }
}
