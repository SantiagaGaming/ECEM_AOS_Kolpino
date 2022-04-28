using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossSoundPlayer : SoundPlayer
{
    [SerializeField] private AudioClip _41sound;
    [SerializeField] private AudioClip _43sound;


    public void Play41Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_41sound);
        currentClip = _41sound;
    }
    public void Play43Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_43sound);
        currentClip = _43sound;
    }
}
