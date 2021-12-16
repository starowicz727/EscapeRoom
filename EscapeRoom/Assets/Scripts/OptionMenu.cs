﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{
    public Button buttonOn, buttonOff;
    public Sprite onImage, onImageCh, offImage, offImageCh;

    public void Start()
    {
        buttonOn.image.sprite = onImageCh;
        buttonOff.image.sprite = offImage;
    }
    public void SoundOn()
    {
        GameState.SoundOn = true;
        FindObjectOfType<AudioManager>().Play("backgroundMenu");
    }
    public void SoundOff()
    {      
        GameState.SoundOn = false;
        FindObjectOfType<AudioManager>().Stop("backgroundMenu"); //musimy wyłączyć muzykę w menu 
    }
    public void Update()
    {
        if (GameState.SoundOn)
        {
            buttonOn.image.sprite = onImageCh;
            buttonOff.image.sprite = offImage;
        }
        else if (!GameState.SoundOn)
        {
            buttonOn.image.sprite = onImage;
            buttonOff.image.sprite = offImageCh;
        }
    }
}
