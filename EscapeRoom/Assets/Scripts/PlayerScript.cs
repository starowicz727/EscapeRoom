using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public void Ustaw()
    {
        float x, z;
        //losowanie pozycji gracza na planszy
        //gracz moze zając jedynie pozycje na planszy
        z = Random.Range(-23.2f, 20.7f);
        x = Random.Range(-21.9f, 22.2f);

        Vector3 v3 = new Vector3(x, 1.4f, z);
        GetComponent<Transform>().transform.position = v3;
    }
    void Start()
    {
        Ustaw();
    }
    void Update()
    {
        //menu
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("Menu");
        }
    }
    
}
