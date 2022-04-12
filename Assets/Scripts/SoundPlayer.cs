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
    public void Play1Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_2sound);
        _currentClip = _2sound;
    }
    public void Play2Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_3sound);
        _currentClip = _3sound;
    }
    public void Play3Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_4sound);
        _currentClip = _4sound;
    }
    public void Play4Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_5sound);
        _currentClip = _5sound;
    }
    public void Play5Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_6sound);
        _currentClip = _6sound;
    }
    public void Play6Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_7sound);
        _currentClip = _7sound;
    }
    public void Play7Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_8sound);
        _currentClip = _8sound;
    }
    public void Play8Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_9sound);
        _currentClip = _9sound;
    }
    public void Play201Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_201sound);
        _currentClip = _201sound;
    }
    public void Play16Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_16sound);
        _currentClip = _16sound;
    }
    public void Play17Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_17sound);
        _currentClip = _17sound;
    }
    public void Play18Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_18sound);
        _currentClip = _18sound;
    }
    public void Play19Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_19sound);
        _currentClip = _19sound;
    }
    public void Play20Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_20sound);
        _currentClip = _20sound;
    }
    public void Play21Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_21sound);
        _currentClip = _21sound;
    }
    public void Play22Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_22sound);
        _currentClip = _22sound;
    }
    public void Play23Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_23sound);
        _currentClip = _23sound;
    }
    public void Play24Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_24sound);
        _currentClip = _24sound;
    }
    public void Play28Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_28sound);
        _currentClip = _28sound;
    }
    public void Play31Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_31sound);
        _currentClip = _31sound;
    }
    public void Play202Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_202sound);
        _currentClip = _202sound;
    }
    public void Play205Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_205sound);
        _currentClip = _205sound;
    }
    public void Play206Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_206sound);
        _currentClip = _206sound;
    }
    public void Play207Sound()
    {
        _audioSource.Stop();
        _audioSource.PlayOneShot(_207sound);
        _currentClip = _207sound;
    }

}
