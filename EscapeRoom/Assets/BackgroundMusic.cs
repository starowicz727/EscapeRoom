using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("backgroundMusic1");
    }
}
