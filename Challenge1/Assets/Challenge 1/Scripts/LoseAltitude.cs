/*Kyree Richardson
 * Challenge 1
 * Makes Player lose
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseAltitude : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 80 || transform.position.y < -51)
        {
            ScoreManager.gameOver = true;
        }
    }
}

