/* Kyree Richardson
 * Assignment 5A
 * Description: Handles score
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{

    public Text scoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //initializes score to 0 at start
        scoreText.text = "Score: " + 0;
    }

    public void AddScore()
    {
        //increments score
        score++;

        //displays the score
        scoreText.text = "Score: " + score;
    }
}
