using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Rotacja : MonoBehaviour
{
    public static event Action<string, int> Rotated = delegate { };
    private bool coroutineAllowed;
    private int numberShown;
    // Start is called before the first frame update
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
    private IEnumerator RotateWheel()
    {
        coroutineAllowed = false;
        for(int i = 0; i <= 11; i++)
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
}
