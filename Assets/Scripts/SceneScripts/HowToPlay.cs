using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlay : MonoBehaviour
{
    //Loads the start scene when the back button is pressed
    public void LoadStartMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
}
