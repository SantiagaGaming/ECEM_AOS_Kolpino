using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    protected AudioSource audioSource;

    protected AudioClip currentClip;
    protected void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public float GetSoundLenght()
    {
        return currentClip.length;
    }
}
