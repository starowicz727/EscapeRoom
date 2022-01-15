using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTeleport : MonoBehaviour // skrypt dopisany do portalu 
{
    private void OnCollisionEnter(Collision collision)
    {
        if( collision.collider.tag == "Player")
        {
            UnlockLevel();
            GameState.SaveMyGameState();
            if (SceneManager.GetActiveScene().name.Equals("Level3"))
            {
                if((GameState.LevelSpecialUnlocked = true) || (GameState.Item1Found && GameState.Item2Found && GameState.Item3Found))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //tu wchodzimy na level z labiryntem
                }
                else
                {
                    SceneManager.LoadScene("Menu");
                }
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }

    private void UnlockLevel()
    {
        if (SceneManager.GetActiveScene().name.Equals("Level1"))
        {
            GameState.Level2Unlocked = true;
        }
        else if (SceneManager.GetActiveScene().name.Equals("Level2"))
        {
            GameState.Level3Unlocked = true;
        }
        else if (SceneManager.GetActiveScene().name.Equals("Level3"))
        {
            GameState.Level3Finished = true;
        }

    }
}
