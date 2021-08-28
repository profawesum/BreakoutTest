using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{

    public Text scoreText;
    public int score;

    public void increaseScore(int scoreToIncrease) {
        score += scoreToIncrease;
    }

    public void Update() {
        scoreText.text = "Score: " + score;
    }
}
