using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkingManPositionChanger : MonoBehaviour
{
    [SerializeField] private Transform _dspPosition;
    [SerializeField] private Transform _yvkPosition;
    [SerializeField] private Transform _relePosition221;
    [SerializeField] private Transform _relePosition231;
    [SerializeField] private Transform _relePosition241;
    [SerializeField] private Transform _relePosition261;
    [SerializeField] private Transform _relePosition281;
    [SerializeField] private Transform _relePositionDDK;


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
    public void ChangeToPositionToRele221()
    {
        transform.position = _relePosition221.position;
        transform.rotation = _relePosition221.rotation;
    }
    public void ChangeToPositionToRele231()
    {
        transform.position = _relePosition231.position;
        transform.rotation = _relePosition231.rotation;
    }
    public void ChangeToPositionToRele241()
    {
        transform.position = _relePosition241.position;
        transform.rotation = _relePosition241.rotation;
    }
    public void ChangeToPositionToRele261()
    {
        transform.position = _relePosition261.position;
        transform.rotation = _relePosition261.rotation;
    }
    public void ChangeToPositionToRele281()
    {
        transform.position = _relePosition281.position;
        transform.rotation = _relePosition281.rotation;
    }
    public void ChangeToPositionToReleDDK()
    {
        transform.position = _relePositionDDK.position;
        transform.rotation = _relePositionDDK.rotation;
    }
}
