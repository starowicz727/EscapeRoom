using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject menu;
    private bool m = false;
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
        //gra = true;
    }
    public void QuitGame()
    {
        Application.Quit();
    }    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        //do testu
        if (Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene("Level2");
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            if(!m){
                //kursor na menu
                menu.SetActive(true);
                m = true;
            }
            else{
                menu.SetActive(false);
                 m = false;
            }            
        }
    }
}
