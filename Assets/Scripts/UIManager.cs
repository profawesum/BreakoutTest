using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Mirror
{

    public class UIManager : NetworkBehaviour
    {

        public Text scoreText;
        public int score;

        public void increaseScore(int scoreToIncrease)
        {
            score += scoreToIncrease;
        }

        public void Update()
        {
            scoreText.text = score.ToString();
        }
    }
}
