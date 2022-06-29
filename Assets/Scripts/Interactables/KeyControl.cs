using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyControl : MonoBehaviour
{
    public GameObject key1;
    public GameObject key2;
    public GameObject[] keysLeft;
    public int keysLife;

    
    //Controls the UI system that disables and enables the key UI images on collection or on use to open a door.
    public void UIControl()
    {
        keysLife += 1; 

        for (int i = 0; i > keysLeft.Length; i++)
        {
            if (keysLife < i)
            {
                keysLeft[i].SetActive(true);
            }
            
        }
    }
}
