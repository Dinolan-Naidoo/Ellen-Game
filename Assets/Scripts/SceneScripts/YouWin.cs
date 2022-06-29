using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWin : MonoBehaviour
{
    //Loads the start scene when the Main Menu button is pressed
    public void returnToMainMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
}
