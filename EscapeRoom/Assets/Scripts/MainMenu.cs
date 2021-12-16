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
    }
}
