using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampObject : BaseObject
{
    [SerializeField] private GameObject _lamp;

    private bool _blink = false;

    public override void StartAction()
    {
        _blink = true;
        StartCoroutine(Blink());
    }
    public override void RevertAction()
    {
        _blink = false;
        _lamp.SetActive(true);
    }
    private IEnumerator Blink()
    {
        if(_blink)
        {
            _lamp.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            _lamp.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Blink());
        }
    }
}
