using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasPositionChanger : MonoBehaviour
{
    [SerializeField] private Transform _talkingManTransform;


    public void ChangeCanvasPostitionToTalkingMan()
    {
        transform.position = _talkingManTransform.position;
        transform.rotation = _talkingManTransform.rotation;
    }
}
