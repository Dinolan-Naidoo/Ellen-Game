using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndPoint : MonoBehaviour
{
    //Loads winning scene if Ellen enters the trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("YouWin");
    }
}
