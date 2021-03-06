using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DspSoundPlayer : SoundPlayer
{
    [SerializeField] private AudioClip _beginDspSound;
    [SerializeField] private AudioClip _3sound;
    [SerializeField] private AudioClip _5sound;
    [SerializeField] private AudioClip _8sound;
    [SerializeField] private AudioClip _9sound;
    [SerializeField] private AudioClip _10sound;
    [SerializeField] private AudioClip _11sound;
    [SerializeField] private AudioClip _16sound;
    [SerializeField] private AudioClip _17sound;
    [SerializeField] private AudioClip _18sound;

    public void PlayBeginSound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_beginDspSound);
        currentClip = _beginDspSound;
    }

    public void Play3Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_3sound);
        currentClip = _3sound;
    }
    public void Play5Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_5sound);
        currentClip = _5sound;
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
