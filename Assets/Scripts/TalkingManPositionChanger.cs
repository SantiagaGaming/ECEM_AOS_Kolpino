using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkingManPositionChanger : MonoBehaviour
{
    [SerializeField] private Transform _dspPosition;
    [SerializeField] private Transform _yvkPosition;

    public void ChangeToDspPosition()
    {
        transform.position = _dspPosition.position;
        transform.rotation = _dspPosition.rotation;
    }
    public void ChangeToPositionToYvk()
    {
        transform.position = _yvkPosition.position;
        transform.rotation = _yvkPosition.rotation;
    }
}
