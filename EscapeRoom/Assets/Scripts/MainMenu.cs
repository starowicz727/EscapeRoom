using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start() //tu wczytujemy dane 
    {
        GameState.LoadMyGameState();

        if (GameState.SoundOn)
        {
            FindObjectOfType<AudioManager>().Play("backgroundMenu");
        }
    }
    public void PlayGame() // te funkcję można usunąć?
    {
        SceneManager.LoadScene("Level1");
        //gra = true;
    }
    public void QuitGame()
    {
        GameState.SaveMyGameState();
        Application.Quit();
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Menu");
        //gra = true;
    }       

    
    public void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Escape))
        // {
        //     Application.Quit();
        // }

        //do testu
        //if (Input.GetKeyDown(KeyCode.T))
        //{
        //    SceneManager.LoadScene("Level2");
        //}
    }
}
