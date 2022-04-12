using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YvkSoundPlayer : SoundPlayer
{
    [SerializeField] private AudioClip _beginYvkSound;
    [SerializeField] private AudioClip _2sound;
    [SerializeField] private AudioClip _3sound;
    [SerializeField] private AudioClip _4sound;
    [SerializeField] private AudioClip _5sound;
    [SerializeField] private AudioClip _6sound;
    [SerializeField] private AudioClip _7sound;
    [SerializeField] private AudioClip _8sound;
    [SerializeField] private AudioClip _9sound;
    [SerializeField] private AudioClip _201sound;
    [SerializeField] private AudioClip _16sound;
    [SerializeField] private AudioClip _17sound;
    [SerializeField] private AudioClip _18sound;
    [SerializeField] private AudioClip _19sound;
    [SerializeField] private AudioClip _20sound;
    [SerializeField] private AudioClip _21sound;
    [SerializeField] private AudioClip _22sound;
    [SerializeField] private AudioClip _23sound;
    [SerializeField] private AudioClip _24sound;
    [SerializeField] private AudioClip _28sound;
    [SerializeField] private AudioClip _31sound;
    [SerializeField] private AudioClip _202sound;
    [SerializeField] private AudioClip _205sound;
    [SerializeField] private AudioClip _206sound;
    [SerializeField] private AudioClip _207sound;
    [SerializeField] private AudioClip _203sound;

    public void PlayBeginSound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_beginYvkSound);
        currentClip = _beginYvkSound;
    }
    public void Play1Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_2sound);
        currentClip = _2sound;
    }
    public void Play2Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_3sound);
        currentClip = _3sound;
    }
    public void Play3Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_4sound);
        currentClip = _4sound;
    }
    public void Play4Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_5sound);
        currentClip = _5sound;
    }
    public void Play5Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_6sound);
        currentClip = _6sound;
    }
    public void Play6Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_7sound);
        currentClip = _7sound;
    }
    public void Play7Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_8sound);
        currentClip = _8sound;
    }
    public void Play8Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_9sound);
        currentClip = _9sound;
    }
    public void Play201Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_201sound);
        currentClip = _201sound;
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
    public void Play19Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_19sound);
        currentClip = _19sound;
    }
    public void Play20Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_20sound);
        currentClip = _20sound;
    }
    public void Play21Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_21sound);
        currentClip = _21sound;
    }
    public void Play22Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_22sound);
        currentClip = _22sound;
    }
    public void Play23Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_23sound);
        currentClip = _23sound;
    }
    public void Play24Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_24sound);
        currentClip = _24sound;
    }
    public void Play28Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_28sound);
        currentClip = _28sound;
    }
    public void Play31Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_31sound);
        currentClip = _31sound;
    }
    public void Play202Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_202sound);
        currentClip = _202sound;
    }
    public void Play205Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_205sound);
        currentClip = _205sound;
    }
    public void Play206Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_206sound);
        currentClip = _206sound;
    }
    public void Play207Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_207sound);
        currentClip = _207sound;
    }
    public void Play203Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_203sound);
        currentClip = _203sound;
    }


}
