using AosSdk.Core.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScenarioStep : ScenarioStep
{
    [SerializeField] private GameObject _repeatButton;
    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            _repeatButton.SetActive(false);

            canvasPostionChanger.ChangeCanvasPositionToDsp();
            playerCanvasController.SetCanvasText(startTextHolder.BeginText);
            Player.Instance.CanMove = false;
        }
        else if (number == 1)
        {
            _repeatButton.SetActive(true);
            EndScenarioStepEvent?.Invoke();
        }
    }
}