using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
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
        Application.Quit();
    }

    public void PlayLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void PlayLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void PlayLevel3()
    {
        SceneManager.LoadScene("Level2");
    }
    public void PlaySpecialLevel()
    {
        SceneManager.LoadScene("Projekt");
    }
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Menu");
        //gra = true;
    }       

    public void StartNewGame()//do dokończenia ?
    {

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
