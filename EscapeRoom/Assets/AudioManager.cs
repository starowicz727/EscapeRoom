using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    void Awake() //awake wykonuje siê tu¿ przed Start()
    {
        foreach(Sound snd in sounds)
        {
            snd.source = gameObject.AddComponent<AudioSource>();
            snd.source.clip = snd.clip;
            snd.source.volume = snd.volume;
            snd.source.pitch = snd.pitch;
            snd.source.loop = snd.loop;
        }
    }

    public void Play(string name)
    {
        Sound fsnd = Array.Find(sounds, sound => sound.name == name); //szukamy w tablicy Sound o nazwie name

        if(fsnd == null)
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
