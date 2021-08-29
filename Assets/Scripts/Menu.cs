using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public void singleplayerPushed() {
        //load the singleplayer level
        SceneManager.LoadScene("SinglePlayerLevel");
    }
    public void multiplayerPushed(){
        //load the multiplayer level
        SceneManager.LoadScene("MultiplayerLevel");
    }
    public void quitPushed(){
        //quit the game
        Application.Quit();
    }
}
