using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpBox : MonoBehaviour
{
    [SerializeField] private Image customImage1;
    [SerializeField] private Image customImage2;
    [SerializeField] private Text customText;

    //Enables the TextBox along with the images.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Ellen"))
        {
            customImage1.enabled = true;
            customImage2.enabled = true;
            customText.enabled = true;
        }
    }

    //Disables the TextBox along with the images.
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Ellen"))
        {
            customImage1.enabled = false;
            customImage2.enabled = false;
            customText.enabled = false;
        }
    }
}
