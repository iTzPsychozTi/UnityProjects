/* Kyree Richardson
 * Prototype 3
 * (Moves objects left)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 15f;
    private float leftBound = -15;
    private PlayerController playerControllerScript;

    void Start()
    {
        playerControllerScript = GameObject.FindGameObjectWithTag
            ("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            //moves object left
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        //destroys game object if its x position is past the leftBound &&
        //its an "Obstacle"
        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
