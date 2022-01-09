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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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

        // jeszcze trzeba dodaæ unlock lvl special 
    }
}
