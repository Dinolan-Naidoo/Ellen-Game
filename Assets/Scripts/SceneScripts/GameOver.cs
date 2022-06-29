using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    //Loads the start scene when the "Main Menu" button is pressed.
    public void returnToMainMenu()
    {
        SceneManager.LoadScene("StartScene");
    }

    //Loads the levels scene when the "Restart" button is pressed.
    public void Restart()
    {
        SceneManager.LoadScene("Zone_WSOA2009_WSOA2024_Exam_Level");
    }
}
