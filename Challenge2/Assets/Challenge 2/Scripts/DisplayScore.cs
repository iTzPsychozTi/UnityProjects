/*
 * (Kyree Richardson)
 * (Challenge 2)
 * (Displays the player's score)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayScore : MonoBehaviour
{
    public Text textbox;

    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //set reference component referenced on start
        textbox = GetComponent<Text>();

        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;

        if (score >= 5)
        {
            //Press 'R' to restart if game is over
            if (Input.GetKeyDown(KeyCode.R))
            {

                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
