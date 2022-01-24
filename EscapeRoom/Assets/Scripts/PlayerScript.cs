using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    // public Slider slider;
    // public Slider sliderScore;
    // private float timer = 0;
    // private float timer2 = 0;
    // bool czyWZasiegu = false;
    //public GameObject[] Des;
    public void Ustaw()
    {
        float x, z;
        //gracz moze zając jedynie pozycje na planszy
        z = Random.Range(-23.2f, 20.7f);
        x = Random.Range(-21.9f, 22.2f);

        Vector3 v3 = new Vector3(x, 1.4f, z);
        GetComponent<Transform>().transform.position = v3;
    }
    void Start()
    {
        Ustaw();
        // DaneGry.zycie = 100;
        // DaneGry.score = 100;
    }
    void Update()
    {
        // Leczenie();
        // IleZycia();

        //lvl 3
        if(Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene("Level3");
        }
        //menu
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("Menu");
        }
    }
    // private void OnTriggerStay(Collider other)
    // {
    //     if (other.gameObject.tag == "NPC")
    //     {
    //         czyWZasiegu = true;
    //         //dodaje czas dopóki npc stoi w triggerze gracza
    //         timer += Time.deltaTime;
    //         //Debug.Log(timer);
    //         if (timer > 2)
    //         {
    //             DaneGry.zycie -= 10;
               
    //             slider.value = DaneGry.zycie;
    //             //zeruje czas
    //             timer = 0;
    //             //odejmuje punkty gdy jest w triggerze i punkty gry nie są na 0
    //             if (DaneGry.score > 0)
    //             {
    //                 DaneGry.score -= 10;
    //                 sliderScore.value = DaneGry.score;
    //             }
    //         }            
    //     }
    // }
    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.gameObject.tag == "Dest")
    //     {
    //         //dodaje do wygranej jak są 4 to wygrywa
    //         DaneGry.destinations += 1;

    //         //cel staje sie nie widoczny
    //         //other.gameObject.GetComponent<MeshRenderer>().enabled = false;

    //         //usuwa obiekt "cel dodatkowy" 
    //         Destroy(other.gameObject);                       
    //         // Destroy(other); // tak nie robic, nie usuwal
    //     }
    // }
    // private void OnTriggerExit(Collider other)
    // {
    //     czyWZasiegu = false;
    // }
    // void Leczenie()
    // {
    //     if(czyWZasiegu == false)
    //     {
    //         timer2 += Time.deltaTime;
    //         //Debug.Log(timer2);
    //         if (timer2 > 5)
    //         {
    //             if(DaneGry.zycie < 100)
    //             {
    //                 DaneGry.zycie += 10;
    //                 slider.value = DaneGry.zycie;
    //             }                
    //             timer2 = 0;
    //         }
    //     }
    //     //jak zasieg true
    //     else
    //     {
    //         timer2 = 0;
    //     }
    // }
    // void IleZycia()
    // {
    //     if (DaneGry.zycie == 0)
    //     {
    //         //Debug.Log("koniec gry");
    //         SceneManager.LoadScene("gameOver");
    //         DaneGry.destinations = 0;
    //         Ustaw();
    //     }
    //     else if (DaneGry.destinations == 4) //raczej tak
    //     {
    //         //Debug.Log("You won");
    //         SceneManager.LoadScene("Level1");
    //         //Debug.Log("Your score: " + DaneGry.score);
    //         DaneGry.destinations = 0;
    //         Ustaw();
    //     }
    // }
}
