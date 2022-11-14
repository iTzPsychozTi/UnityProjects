/*
 * Kyree Richardson
 * Prototype 4
 * Controller for player
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    public float speed;
    private float forwardInput;

    private GameObject focalPoint;

    public bool hasPowerup;
    private float powerupStrength = 15.0f;

    public GameObject powerupIndicator;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        focalPoint = GameObject.FindGameObjectWithTag("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");

        //move our powerup indicator to the ground below our player
        powerupIndicator.transform.position =
            transform.position + new Vector3(0, -0.5f, 0);
    }

    private void FixedUpdate()
    {
        playerRB.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PowerUp"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
            powerupIndicator.gameObject.SetActive(true);
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
        powerupIndicator.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Debug.Log("Player collided with " + collision.gameObject.name
                + "with powerup set to " + hasPowerup);

            //get a local reference to the enemy rb
            Rigidbody enemyRigidBody = collision.gameObject.GetComponent
                <Rigidbody>();

            //set a vector3 with a direction away from the player
            Vector3 awayFromPlayer =
                (collision.gameObject.transform.position - transform.position).normalized;

            //add force away from player
            enemyRigidBody.AddForce(awayFromPlayer * powerupStrength,
                ForceMode.Impulse);
        }
    }
}
