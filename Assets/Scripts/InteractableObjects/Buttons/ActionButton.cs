using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;

public class ActionButton : BaseButtton
{
    [SerializeField] private BaseObject _actionObject;

    public override void OnClicked(InteractHand interactHand)
    {
        _actionObject.Action();
    }
}
