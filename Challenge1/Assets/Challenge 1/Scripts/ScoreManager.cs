/*Kyree Richardson
 * Challenge 1
 * Manages Score
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static bool gameOver = false;
    public static bool won = false;
    public static int score = 0;

    public Text textbox;


    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //if game not over display score
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }

        //win condition 5 or more points
        if (score >= 5)
        {
            won = true;
            gameOver = true;
        }



        if (gameOver)
        {
            if (won)
            {
                textbox.text = "You win!\nPress R to try for a higher score.";
            }
            else
            {
                textbox.text = "You lose!\nPress R to try again.";
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}