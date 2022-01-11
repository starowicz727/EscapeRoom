using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{ //skrypt dodany do obiektu empty BackgroundMusic

    void Start()
    {
        if (SceneManager.GetActiveScene().name.Equals("Menu"))
        {
            FindObjectOfType<AudioManager>().Play("backgroundMenu");
        }
        else
        {
            FindObjectOfType<AudioManager>().Play("backgroundMusic1");
        }
    }
}
