using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkingMan : MonoBehaviour
{
    private Animator _anim;
    private void Start()
    {
        _anim = GetComponent<Animator>();
    }

    public void EnableTalking(bool value)
    {
        _anim.SetBool("Talk", value);
    }
}
