using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossSoundPlayer : SoundPlayer
{
    [SerializeField] private AudioClip _41sound;
    [SerializeField] private AudioClip _42sound;
    [SerializeField] private AudioClip _43sound;
    [SerializeField] private AudioClip _44sound;
    [SerializeField] private AudioClip _45sound;

    public void Play41Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_41sound);
        currentClip = _41sound;
    }
    public void Play42Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_42sound);
        currentClip = _42sound;
    }
    public void Play43Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_43sound);
        currentClip = _43sound;
    }
    public void Play44Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_44sound);
        currentClip = _44sound;
    }
    public void Play45Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_45sound);
        currentClip = _45sound;
    }
}
