using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    //Loads the levels scene when the "Play" button is pressed.
    public void playGame()
    {
        SceneManager.LoadScene("Zone_WSOA2009_WSOA2024_Exam_Level");
    }

    //Loads the how to play scene when the button is pressed
    public void howToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    
    //Exits the game.
    public void quitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
