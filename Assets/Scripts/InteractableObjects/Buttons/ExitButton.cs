using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : BaseButtton
{

    public override void OnClicked(InteractHand interactHand)
    {
        Application.Quit();
    }
}
