using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatButton : BaseButtton
{
    [SerializeField] private PlayerCanvasViev _playerCanvasViev;
    public override void OnClicked(InteractHand interactHand)
{
    _playerCanvasViev.TapRepeatActionButtonEvent?.Invoke();
}
}