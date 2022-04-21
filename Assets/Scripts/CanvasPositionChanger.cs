using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasPositionChanger : MonoBehaviour
{
    [SerializeField] private Transform _talkingManTransform;
    [SerializeField] private Transform _yvkPosition;
    [SerializeField] private Transform _dspPosition;
    [SerializeField] private Transform _relePosition221;
    [SerializeField] private Transform _relePosition231;
    [SerializeField] private Transform _relePosition241;
    [SerializeField] private Transform _relePosition261;
    [SerializeField] private Transform _relePosition281;
    [SerializeField] private Transform _relePositionDDK;
    [SerializeField] private Transform _crossPosition;
    [SerializeField] private Transform _pitPosition;
    [SerializeField] private Transform _dgaPosition;

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
    public void ChangeCanvasPositionToRele221()
    {
        transform.position = _relePosition221.position;
        transform.rotation = _relePosition221.rotation;
    }
    public void ChangeCanvasPositionToRele231()
    {
        transform.position = _relePosition231.position;
        transform.rotation = _relePosition231.rotation;
    }
    public void ChangeCanvasPositionToRele241()
    {
        transform.position = _relePosition241.position;
        transform.rotation = _relePosition241.rotation;
    }
    public void ChangeCanvasPositionToRele261()
    {
        transform.position = _relePosition261.position;
        transform.rotation = _relePosition261.rotation;
    }
    public void ChangeCanvasPositionToRele281()
    {
        transform.position = _relePosition281.position;
        transform.rotation = _relePosition281.rotation;
    }
    public void ChangeCanvasPositionToReleDDK()
    {
        transform.position = _relePositionDDK.position;
        transform.rotation = _relePositionDDK.rotation;
    }
    public void ChangeCanvasPositionToCross()
    {
        transform.position = _crossPosition.position;
        transform.rotation = _crossPosition.rotation;
    }
    public void ChangeCanvasPositionToPit()
    {
        transform.position = _pitPosition.position;
        transform.rotation = _pitPosition.rotation;
    }
    public void ChangeCanvasPositionToDga()
    {
        transform.position = _dgaPosition.position;
        transform.rotation = _dgaPosition.rotation;
    }

}
