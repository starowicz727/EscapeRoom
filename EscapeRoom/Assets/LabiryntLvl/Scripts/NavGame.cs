using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NavGame : MonoBehaviour
{
    void Update()
    {
        //wyjscie
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        //kolejne podejscie
        if (Input.GetKeyDown(KeyCode.R))
        {
            Projekt();           
        }
        //start
        if (Input.GetKeyDown(KeyCode.S))
        {
            Projekt();           
        }      
    }
    public void Projekt()
    {
        SceneManager.LoadScene("Projekt");
        DaneGry.score = 100;
        DaneGry.zycie = 100;
        DaneGry.destinations = 0;
    }
}
