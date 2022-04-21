using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DgaSoundPlayer : SoundPlayer
{
    [SerializeField] private AudioClip _68sound;
    [SerializeField] private AudioClip _69sound;
    [SerializeField] private AudioClip _70sound;
    [SerializeField] private AudioClip _71sound;
    [SerializeField] private AudioClip _72sound;
    [SerializeField] private AudioClip _73sound;
    [SerializeField] private AudioClip _74sound;
    [SerializeField] private AudioClip _75sound;
    [SerializeField] private AudioClip _76sound;
    [SerializeField] private AudioClip _77sound;
    [SerializeField] private AudioClip _78sound;
    [SerializeField] private AudioClip _79sound;
    [SerializeField] private AudioClip _80sound;
    [SerializeField] private AudioClip _81sound;
    [SerializeField] private AudioClip _82sound;

    public void Play68Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_68sound);
        currentClip = _68sound;
    }
    public void Play69Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_69sound);
        currentClip = _69sound;
    }
    public void Play70Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_70sound);
        currentClip = _70sound;
    }
    public void Play71Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_71sound);
        currentClip = _71sound;
    }
    public void Play72Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_72sound);
        currentClip = _72sound;
    }
    public void Play73Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_73sound);
        currentClip = _73sound;
    }
    public void Play74Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_74sound);
        currentClip = _74sound;
    }
    public void Play75Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_75sound);
        currentClip = _75sound;
    }
    public void Play76Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_76sound);
        currentClip = _76sound;
    }
    public void Play77Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_77sound);
        currentClip = _77sound;
    }
    public void Play78Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_78sound);
        currentClip = _78sound;
    }
    public void Play79Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_79sound);
        currentClip = _79sound;
    }
    public void Play80Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_80sound);
        currentClip = _80sound;
    }
    public void Play81Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_81sound);
        currentClip = _81sound;
    }
    public void Play82Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_82sound);
        currentClip = _82sound;
    }

}
