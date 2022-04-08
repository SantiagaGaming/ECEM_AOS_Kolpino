using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _beginSound;
    [SerializeField] private AudioClip _2sound;
    [SerializeField] private AudioClip _3sound;
    [SerializeField] private AudioClip _4sound;
    [SerializeField] private AudioClip _5sound;
    [SerializeField] private AudioClip _6sound;
    [SerializeField] private AudioClip _7sound;
    [SerializeField] private AudioClip _8sound;
    [SerializeField] private AudioClip _9sound;


    private AudioClip _currentClip;
    public float GetSoundLenght()
    {
        return _currentClip.length;
    }

    public void PlayBeginSound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_beginSound);
        _currentClip = _beginSound;
    }
    public void Play2Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_2sound);
        _currentClip = _2sound;
    }
    public void Play3Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_3sound);
        _currentClip = _3sound;
    }
    public void Play4Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_4sound);
        _currentClip = _4sound;
    }
    public void Play5Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_5sound);
        _currentClip = _5sound;
    }
    public void Play6Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_6sound);
        _currentClip = _6sound;
    }
    public void Play7Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_7sound);
        _currentClip = _7sound;
    }
    public void Play8Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_8sound);
        _currentClip = _8sound;
    }
    public void Play9Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_9sound);
        _currentClip = _9sound;
    }



}
