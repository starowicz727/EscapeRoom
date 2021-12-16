using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds; //wszystkie d�wi�ki w grze 
    void Awake() //awake wykonuje si� tu� przed Start()
    {
        foreach(Sound snd in sounds)
        {
            snd.source = this.gameObject.AddComponent<AudioSource>(); //audiosource si� b�dzie przypisywa� do audiomanagera 
            snd.source.clip = snd.clip;
            snd.source.volume = snd.volume;  //g�o�no�� 
            snd.source.pitch = snd.pitch;  //wysoko�� d�wi�ku
            snd.source.loop = snd.loop;    
        }
    }

    public void Play(string name)
    {
        if (GameState.SoundOn)
        {
            Sound fsnd = Array.Find(sounds, sound => sound.name == name); //szukamy w tablicy Sound o nazwie name

            if (fsnd == null)
            {
                Debug.LogWarning("Didn't found sound named " + name);  //je�li nie znajdziemy to mamy o tym informacj� w Console
                return;
            }
            else
            {
                fsnd.source.Play();
            }
        }
    }
    public void Stop(string name)
    {
        Sound fsnd = Array.Find(sounds, sound => sound.name == name); //szukamy w tablicy Sound o nazwie name

        if (fsnd == null)
        {
            Debug.LogWarning("Didn't found sound named " + name);  //je�li nie znajdziemy to mamy o tym informacj� w Console
            return;
        }
        else
        {
            fsnd.source.Stop();
        }
    }
}
