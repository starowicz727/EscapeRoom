using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{ //skrypt dodany do obiektu empty BackgroundMusic

    void Start()
    {
        FindObjectOfType<AudioManager>().Play("backgroundMusic1");
    }
}
