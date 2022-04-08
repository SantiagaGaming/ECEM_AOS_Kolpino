using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampObject : BaseObject
{
    [SerializeField] private GameObject _lamp;

    public override void StartAction()
    {
        _lamp.SetActive(true);
    }
    public override void RevertAction()
    {
        _lamp.SetActive(false);
    }
}
