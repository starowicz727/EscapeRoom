using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour
{
    public GameObject menu;
    public GameObject won;
    private bool e = false;

    public void Update()
    {
        //wychodzenie z gry raczej przez przycisk tylko
        // if (Input.GetKeyDown(KeyCode.Escape))
        // {
        //     Application.Quit();
        // }
        //do testu
        if (Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene("Level2");
        }
        // if (Input.GetKeyDown(KeyCode.O))
        // {
        //     letter.SetActive(false);
        // }
        //esc uruchamia podreczne menu
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            won.SetActive(false);
            if(!e){
                //kursor na menu
                menu.SetActive(true);
                e = true;
            }
            else{
                menu.SetActive(false);
                e = false;
            }            
        }        
    }

    //problem: esc wychodzi z poruszania sie po planszy
    // public void No(){
    //     menu.SetActive(false);
    //     e = false;
    // }
}
