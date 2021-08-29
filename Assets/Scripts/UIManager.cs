using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;
using UnityEngine.SceneManagement;

namespace Mirror
{

    public class UIManager : NetworkBehaviour
    {

        public Text scoreText;

        [SyncVar] public int score;

        public void FixedUpdate()
        {
            //set the score text
            scoreText.text = score.ToString();

            //display a win message
            if (score == 5000) {
                scoreText.text = score.ToString() + " YOU WIN";  
            }

            //make it so the player can return to the main menu
            if (Input.GetKey(KeyCode.Escape))
            {
                //load the main menu
                SceneManager.LoadScene(0);
            }
        }
    }
}
