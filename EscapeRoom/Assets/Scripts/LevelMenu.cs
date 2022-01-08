using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    public Button btnLvl2, btnLvl3, btnLvlSpecial;
    public Button btnLvl2Img, btnLvl3Img, btnLvlSpecialImg;
    private void Start()
    {
        if (GameState.Level2Unlocked)
        {
            btnLvl2.interactable = true;
            btnLvl2Img.gameObject.SetActive(true);
        }
        else
        {
            btnLvl2.interactable = false;
            btnLvl2Img.gameObject.SetActive(false);
        }
        if (GameState.Level3Unlocked)
        {
            btnLvl3.interactable = true;
            btnLvl3Img.gameObject.SetActive(true);
        }
        else
        {
            btnLvl3.interactable = false;
            btnLvl3Img.gameObject.SetActive(false);
        }
        if (GameState.LevelSpecialUnlocked)
        {
            btnLvlSpecial.interactable = true;
            btnLvlSpecialImg.gameObject.SetActive(true);
        }
        else
        {
            btnLvlSpecial.interactable = false;
            btnLvlSpecialImg.gameObject.SetActive(false);
        }
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
      
    public void StartNewGame()//do dokończenia ?
    {

    }
    
   
}
