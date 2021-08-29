using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIManagerSP : MonoBehaviour
{

    public Text scoreText;
    public int score;

    public void increaseScore(int scoreToIncrease) {
        score += scoreToIncrease;
    }

    public void Update() {

        //display the score
        scoreText.text = score.ToString();

        //if the score is 5000 display a win message
        if (score == 5000) {
            scoreText.text = score.ToString() + " You Win";
        }

        //load the main menu
        if (Input.GetKey(KeyCode.Escape)) {
            SceneManager.LoadScene(0);
        }
    }
}
