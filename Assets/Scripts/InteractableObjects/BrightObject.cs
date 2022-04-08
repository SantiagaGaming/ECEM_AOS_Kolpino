using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrightObject : BaseObject
{
    private Color _showObjectColor;
    private Color _baseObjectColor;
    private void Start()
    {
        // _showObjectColor = new Color(0.05202916f, 0.6003655f, 0.745283f);
         _baseObjectColor = GetComponent<Renderer>().material.color;
        _showObjectColor = _baseObjectColor * 1.5f;
    }
    public override void StartAction()
    {
        GetComponent<Renderer>().material.color = _showObjectColor;
    }
    public override void RevertAction()
    {
        GetComponent<Renderer>().material.color = _baseObjectColor;
    }
}
