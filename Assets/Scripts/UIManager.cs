using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

namespace Mirror
{

    public class UIManager : NetworkBehaviour
    {

        public Text scoreText;

        [SyncVar] public int score;

        //public void increaseScore(int scoreToIncrease)
        //{
        //    score += scoreToIncrease;
        //}

        public void FixedUpdate()
        {
            scoreText.text = score.ToString();

            if (score == 5000) {
                Time.timeScale = 0;
                scoreText.text = score.ToString() + "  YOU WIN";
            }
        }
    }
}
