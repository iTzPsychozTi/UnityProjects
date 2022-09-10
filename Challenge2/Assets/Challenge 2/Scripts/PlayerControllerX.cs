using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float inputDelay = 4.0f;

    public HealthSystem healthSystem;

    // Update is called once per frame
    void Update()
    {
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").
            GetComponent<HealthSystem>();

        StartCoroutine(nonSpammingSpacebarWithCoroutine());

    }

    IEnumerator nonSpammingSpacebarWithCoroutine()
    {
        while (!healthSystem.gameOver)
        {
            yield return new WaitForSeconds(inputDelay);
        }
    }


    void nonSpammingSpacebar()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
