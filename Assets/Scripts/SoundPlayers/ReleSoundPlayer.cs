using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleSoundPlayer : SoundPlayer
{
    [SerializeField] private AudioClip _19sound;
    [SerializeField] private AudioClip _22sound;
    [SerializeField] private AudioClip _24sound;
    [SerializeField] private AudioClip _31sound;
    [SerializeField] private AudioClip _32sound;
    [SerializeField] private AudioClip _33sound;
    [SerializeField] private AudioClip _36sound;
    [SerializeField] private AudioClip _37sound;
    [SerializeField] private AudioClip _38sound;
    [SerializeField] private AudioClip _39sound;

    public void Play19Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_19sound);
        currentClip = _19sound;
    }
    public void Play22Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_22sound);
        currentClip = _22sound;
    }
    public void Play24Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_24sound);
        currentClip = _24sound;
    }
    public void Play31Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_31sound);
        currentClip = _31sound;
    }
    public void Play32Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_32sound);
        currentClip = _32sound;
    }
    public void Play33Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_33sound);
        currentClip = _33sound;
    }
    public void Play36Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_36sound);
        currentClip = _36sound;
    }
    public void Play37Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_37sound);
        currentClip = _37sound;
    }
    public void Play38Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_38sound);
        currentClip = _38sound;
    }
    public void Play39Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_39sound);
        currentClip = _39sound;
    }


}
