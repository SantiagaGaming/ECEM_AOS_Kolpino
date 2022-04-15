using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YvkSoundPlayer2 : SoundPlayer
{
    [SerializeField] private AudioClip _95sound;
    [SerializeField] private AudioClip _97sound;
    [SerializeField] private AudioClip _105_1sound;
    [SerializeField] private AudioClip _105_2sound;
    [SerializeField] private AudioClip _221sound;
    [SerializeField] private AudioClip _222sound;
    [SerializeField] private AudioClip _223sound;
    [SerializeField] private AudioClip _224sound;
    [SerializeField] private AudioClip _225sound;
    [SerializeField] private AudioClip _226sound;

    public void Play95Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_95sound);
        currentClip = _95sound;
    }
    public void Play97Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_97sound);
        currentClip = _97sound;
    }
    public void Play221Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_221sound);
        currentClip = _221sound;
    }
    public void Play222Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_222sound);
        currentClip = _222sound;
    }
    public void Play223Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_223sound);
        currentClip = _223sound;
    }
    public void Play224Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_224sound);
        currentClip = _224sound;
    }
    public void Play225Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_225sound);
        currentClip = _225sound;
    }
    public void Play226Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_226sound);
        currentClip = _226sound;
    }
    public void Play105_1Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_105_1sound);
        currentClip = _105_1sound;
    }
    public void Play105_2Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_105_2sound);
        currentClip = _105_2sound;
    }

}
