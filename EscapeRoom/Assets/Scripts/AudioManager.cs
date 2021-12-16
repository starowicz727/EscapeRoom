using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds; //wszystkie dŸwiêki w grze 
    void Awake() //awake wykonuje siê tu¿ przed Start()
    {
        foreach(Sound snd in sounds)
        {
            snd.source = this.gameObject.AddComponent<AudioSource>(); //audiosource siê bêdzie przypisywaæ do audiomanagera 
            snd.source.clip = snd.clip;
            snd.source.volume = snd.volume;  //g³oœnoœæ 
            snd.source.pitch = snd.pitch;  //wysokoœæ dŸwiêku
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
                Debug.LogWarning("Didn't found sound named " + name);  //jeœli nie znajdziemy to mamy o tym informacjê w Console
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
            Debug.LogWarning("Didn't found sound named " + name);  //jeœli nie znajdziemy to mamy o tym informacjê w Console
            return;
        }
        else
        {
            fsnd.source.Stop();
        }
    }
}
