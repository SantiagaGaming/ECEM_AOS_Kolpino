using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonitorObject : BaseObject
{
    [SerializeField] private GameObject _monitorImage;

    public override void StartAction()
    {
        if (_monitorImage.activeSelf == false)
            _monitorImage.SetActive(true);
        else _monitorImage.SetActive(false);
    }
    public override void RevertAction()
    {
        if (_monitorImage.activeSelf == false)
            _monitorImage.SetActive(true);
        else _monitorImage.SetActive(false);
    }

}
        
