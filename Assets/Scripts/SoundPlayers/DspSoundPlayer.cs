using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DspSoundPlayer : SoundPlayer
{
    [SerializeField] private AudioClip _beginDspSound;
    [SerializeField] private AudioClip _2sound;
    [SerializeField] private AudioClip _3sound;
    [SerializeField] private AudioClip _4sound;
    [SerializeField] private AudioClip _5sound;
    [SerializeField] private AudioClip _6sound;
    [SerializeField] private AudioClip _7sound;
    [SerializeField] private AudioClip _8sound;
    [SerializeField] private AudioClip _9sound;
    [SerializeField] private AudioClip _10sound;
    [SerializeField] private AudioClip _11sound;
    [SerializeField] private AudioClip _12sound;
    [SerializeField] private AudioClip _13sound;
    [SerializeField] private AudioClip _14sound;
    [SerializeField] private AudioClip _15sound;
    [SerializeField] private AudioClip _16sound;
    [SerializeField] private AudioClip _17sound;
    [SerializeField] private AudioClip _18sound;

    public void PlayBeginSound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_beginDspSound);
        currentClip = _beginDspSound;
    }
    public void Play2Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_2sound);
        currentClip = _2sound;
    }
    public void Play3Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_3sound);
        currentClip = _3sound;
    }
    public void Play4Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_4sound);
        currentClip = _4sound;
    }
    public void Play5Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_5sound);
        currentClip = _5sound;
    }
    public void Play6Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_6sound);
        currentClip = _6sound;
    }
    public void Play7Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_7sound);
        currentClip = _7sound;
    }
    public void Play8Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_8sound);
        currentClip = _8sound;
    }
    public void Play9Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_9sound);
        currentClip = _9sound;
    }
    public void Play10Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_10sound);
        currentClip = _10sound;
    }
    public void Play11Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_11sound);
        currentClip = _11sound;
    }
    public void Play12Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_12sound);
        currentClip = _12sound;
    }
    public void Play13Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_13sound);
        currentClip = _13sound;
    }
    public void Play14Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_14sound);
        currentClip = _14sound;
    }
    public void Play15Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_15sound);
        currentClip = _15sound;
    }
    public void Play16Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_16sound);
        currentClip = _16sound;
    }
    public void Play17Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_17sound);
        currentClip = _17sound;
    }
    public void Play18Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_18sound);
        currentClip = _18sound;
    }
}
