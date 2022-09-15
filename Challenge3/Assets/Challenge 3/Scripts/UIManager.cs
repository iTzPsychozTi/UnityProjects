/* Kyree Richardson
 * Challenge 3
 * (Manages all of the UI within the game)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public Text loseText;
    public int score = 0;

    public PlayerControllerX playerControllerScript;

    public bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }

        if (playerControllerScript == null)
        {
            playerControllerScript = GameObject.FindGameObjectWithTag
                ("Player").GetComponent<PlayerControllerX>();
        }

        scoreText.text = "Score: 0";
    }

    void Update()
    {
        //Displays score until game is over
        if (!playerControllerScript.gameOver)
        {
            scoreText.text = "Score: " + score;
        }

        //loss condition: hits the bomb
        if (playerControllerScript.gameOver && !won)
        {
            scoreText.text = "You lose!\nPress 'R' to try again.";
        }

        //win condition: 15 points
        if (score >= 15)
        {
            playerControllerScript.gameOver = true;
            won = true;

            scoreText.text = "You win!\nPress 'R' to try again.";
        }

        if (playerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
