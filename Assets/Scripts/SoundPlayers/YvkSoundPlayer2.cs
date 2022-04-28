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
    [SerializeField] private AudioClip _106_1sound;
    [SerializeField] private AudioClip _106_2sound;
    [SerializeField] private AudioClip _106_3sound;
    [SerializeField] private AudioClip _106_4sound;
    [SerializeField] private AudioClip _107_1sound;
    [SerializeField] private AudioClip _107_2sound;
    [SerializeField] private AudioClip _107_3sound;
    [SerializeField] private AudioClip _124sound;
    [SerializeField] private AudioClip _147sound;
    [SerializeField] private AudioClip _148sound;
    [SerializeField] private AudioClip _162sound;
    [SerializeField] private AudioClip _170sound;
    [SerializeField] private AudioClip _188sound;
    [SerializeField] private AudioClip _189sound;
    [SerializeField] private AudioClip _193sound;
    [SerializeField] private AudioClip _194sound;

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
    public void Play106_1Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_106_1sound);
        currentClip = _106_1sound;
    }
    public void Play106_2Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_106_2sound);
        currentClip = _106_2sound;
    }
    public void Play106_3Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_106_3sound);
        currentClip = _106_3sound;
    }
    public void Play106_4Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_106_4sound);
        currentClip = _106_4sound;
    }
    public void Play107_1Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_107_1sound);
        currentClip = _107_1sound;
    }
    public void Play107_2Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_107_2sound);
        currentClip = _107_2sound;
    }
    public void Play107_3Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_107_3sound);
        currentClip = _107_3sound;
    }
    public void Play124Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_124sound);
        currentClip = _124sound;
    }
    public void Play147Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_147sound);
        currentClip = _147sound;
    }
    public void Play148Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_148sound);
        currentClip = _148sound;
    }
    public void Play162Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_162sound);
        currentClip = _162sound;
    }
    public void Play170Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_170sound);
        currentClip = _170sound;
    }
    public void Play188Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_188sound);
        currentClip = _188sound;
    }
    public void Play189Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_189sound);
        currentClip = _189sound;
    }

    public void Play193Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_193sound);
        currentClip = _193sound;
    }
    public void Play194Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_194sound);
        currentClip = _194sound;
    }

}
