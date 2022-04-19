using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;

public class InteractObject : MonoBehaviour ,IClickAble, IHoverAble
{
    protected Color _showObjectColor;
    protected Color _baseObjectColor;

    [SerializeField] private string _name;

    public bool IsHoverable { get; set; } = true;
    public bool IsClickable { get; set; } = true;
    protected void Start()
    {
        _baseObjectColor = GetComponent<Renderer>().material.color;
        _showObjectColor = _baseObjectColor * 1.5f;
        if (GetComponent<Collider>())
            GetComponent<Collider>().enabled = false;
    }
    public void ActivateInteraction(bool value)
    {
        if(GetComponent<Collider>())
        GetComponent<Collider>().enabled = value;
    }


    public void OnClicked(InteractHand interactHand)
    {
        StartObjectAction();
    }
    public virtual void StartObjectAction()
    {
        
    }

    public string GetInteractObjectName()
    {
        return _name;
    }

    public void OnHoverIn(InteractHand interactHand)
    {
        GetComponent<Renderer>().material.color = _showObjectColor;
    }

    public void OnHoverOut(InteractHand interactHand)
    {
        GetComponent<Renderer>().material.color = _baseObjectColor;
    }
}
