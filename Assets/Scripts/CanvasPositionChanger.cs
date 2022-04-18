using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasPositionChanger : MonoBehaviour
{
    [SerializeField] private Transform _talkingManTransform;
    [SerializeField] private Transform _yvkPosition;
    [SerializeField] private Transform _dspPosition;
    [SerializeField] private Transform _relePosition;

    public void ChangeCanvasPostitionToTalkingMan()
    {
        transform.position = _talkingManTransform.position;
        transform.rotation = _talkingManTransform.rotation;
    }
    public void ChangeCanvasPositionToYvk()
    {
        transform.position = _yvkPosition.position;
        transform.rotation = _yvkPosition.rotation;
    }
    public void ChangeCanvasPositionToDsp()
    {
        transform.position = _dspPosition.position;
        transform.rotation = _dspPosition.rotation;
    }
    public void ChangeCanvasPositionToRele()
    {
        transform.position = _relePosition.position;
        transform.rotation = _relePosition.rotation;
    }

}
