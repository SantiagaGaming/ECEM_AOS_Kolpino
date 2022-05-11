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
    [SerializeField] private AudioClip _21sound;
    [SerializeField] private AudioClip _22sound;
    [SerializeField] private AudioClip _24sound;
    [SerializeField] private AudioClip _28sound;
    [SerializeField] private AudioClip _202sound;
    [SerializeField] private AudioClip _205sound;
    [SerializeField] private AudioClip _206sound;
    [SerializeField] private AudioClip _207sound;
    [SerializeField] private AudioClip _203sound;
    [SerializeField] private AudioClip _44sound;
    [SerializeField] private AudioClip _45_1sound;
    [SerializeField] private AudioClip _45_2sound;
    [SerializeField] private AudioClip _46sound;
    [SerializeField] private AudioClip _47sound;
    [SerializeField] private AudioClip _204sound;
    [SerializeField] private AudioClip _58sound;
    [SerializeField] private AudioClip _59sound;
    [SerializeField] private AudioClip _60sound;
    [SerializeField] private AudioClip _63sound;
    [SerializeField] private AudioClip _74sound;
    [SerializeField] private AudioClip _82sound;
    [SerializeField] private AudioClip _83sound;
    [SerializeField] private AudioClip _84sound;
    [SerializeField] private AudioClip _85sound;
    [SerializeField] private AudioClip _88sound;
    [SerializeField] private AudioClip _89sound;
    [SerializeField] private AudioClip _90_1sound;
    [SerializeField] private AudioClip _90_2sound;
    [SerializeField] private AudioClip _90_3sound;
    [SerializeField] private AudioClip _90_4sound;
    [SerializeField] private AudioClip _90_5sound;
    [SerializeField] private AudioClip _93sound;
    [SerializeField] private AudioClip _94sound;
    [SerializeField] private AudioClip _208sound;
    [SerializeField] private AudioClip _209sound;
    [SerializeField] private AudioClip _210sound;
    [SerializeField] private AudioClip _211sound;
    [SerializeField] private AudioClip _212sound;
    [SerializeField] private AudioClip _213sound;
    [SerializeField] private AudioClip _214sound;
    [SerializeField] private AudioClip _215sound;
    [SerializeField] private AudioClip _216sound;
    [SerializeField] private AudioClip _217sound;
    [SerializeField] private AudioClip _218sound;
    [SerializeField] private AudioClip _219sound;
    [SerializeField] private AudioClip _220sound;



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
    public void Play44Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_44sound);
        currentClip = _44sound;
    }
    public void Play45_1Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_45_1sound);
        currentClip = _45_1sound;
    }
    public void Play45_2Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_45_2sound);
        currentClip = _45_2sound;
    }
    public void Play46Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_46sound);
        currentClip = _46sound;
    }
    public void Play47Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_47sound);
        currentClip = _47sound;
    }
    public void Play204Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_204sound);
        currentClip = _204sound;
    }
    public void Play58Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_58sound);
        currentClip = _58sound;
    }
    public void Play59Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_59sound);
        currentClip = _59sound;
    }
    public void Play60Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_60sound);
        currentClip = _60sound;
    }
    public void Play63Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_63sound);
        currentClip = _63sound;
    }
    public void Play74Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_74sound);
        currentClip = _74sound;
    }
    public void Play82Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_82sound);
        currentClip = _82sound;
    }
    public void Play83Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_83sound);
        currentClip = _83sound;
    }
    public void Play84Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_84sound);
        currentClip = _84sound;
    }
    public void Play85Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_85sound);
        currentClip = _85sound;
    }
    public void Play88Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_88sound);
        currentClip = _88sound;
    }
    public void Play89Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_89sound);
        currentClip = _89sound;
    }
    public void Play90_1Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_90_1sound);
        currentClip = _90_1sound;
    }
    public void Play90_2Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_90_2sound);
        currentClip = _90_2sound;
    }
    public void Play90_3Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_90_3sound);
        currentClip = _90_3sound;
    }
    public void Play90_4Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_90_4sound);
        currentClip = _90_4sound;
    }
    public void Play90_5Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_90_5sound);
        currentClip = _90_5sound;
    }
    public void Play93Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_93sound);
        currentClip = _93sound;
    }
    public void Play94Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_94sound);
        currentClip = _94sound;
    }
    public void Play208Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_208sound);
        currentClip = _208sound;
    }
    public void Play209Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_209sound);
        currentClip = _209sound;
    }
    public void Play210Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_210sound);
        currentClip = _210sound;
    }
    public void Play211Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_211sound);
        currentClip = _211sound;
    }
    public void Play212Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_212sound);
        currentClip = _212sound;
    }
    public void Play213Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_213sound);
        currentClip = _213sound;
    }
    public void Play214Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_214sound);
        currentClip = _214sound;
    }
    public void Play215Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_215sound);
        currentClip = _215sound;
    }
    public void Play216Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_216sound);
        currentClip = _216sound;
    }
    public void Play217Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_217sound);
        currentClip = _217sound;
    }
    public void Play218Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_218sound);
        currentClip = _218sound;
    }
    public void Play219Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_219sound);
        currentClip = _219sound;
    }
    public void Play220Sound()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(_220sound);
        currentClip = _220sound;
    }
}
