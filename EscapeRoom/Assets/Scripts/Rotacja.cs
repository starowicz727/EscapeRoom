using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Rotacja : MonoBehaviour //skrypt przypisany do poszczególnych kó³ zamka
{
    public static event Action<string, int> Rotated = delegate { };
    private bool coroutineAllowed;
    private int numberShown;
    public int scena;
    private void Start()
    {
        coroutineAllowed = true;
        numberShown = 5;
    }
    private void OnMouseDown()
    {
        if (coroutineAllowed)
        {
            StartCoroutine("RotateWheel");
            
        }
    }
    private IEnumerator RotateWheel() //obrót kó³ka o jedn¹ wartoœæ oraz uruchomienie dŸwiêku po naciœniêciu
    {
        if (scena == 1 || scena == 2)
        {
            coroutineAllowed = false;
            for (int i = 0; i <= 11; i++)
            {
                transform.Rotate(0f, -3f, 0f);
                FindObjectOfType<AudioManager>().Play("locker1");
                yield return new WaitForSeconds(0.01f);
            }
            coroutineAllowed = true;
            numberShown += 1;
            if (numberShown >= 10)
            {
                numberShown = 0;
            }
            Rotated(name, numberShown);
        }
        if (scena == 3)
        {
            coroutineAllowed = false;
            for (int i = 0; i <= 13; i++)
            {
                transform.Rotate(0f, 0f, 2.1429f);
                yield return new WaitForSeconds(0.01f);
            }
            coroutineAllowed = true;
            numberShown += 1;
            if (numberShown >= 13)
            {
                numberShown = 1;               
            }
            Rotated(name, numberShown);
        }
    }
}
