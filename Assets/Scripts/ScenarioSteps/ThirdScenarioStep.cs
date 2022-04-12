using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ThirdScenarioStep : ScenarioStep
{
    public UnityAction ShowRepeatButtonEvent;

    [SerializeField] private OpenDoorController _openDoorController;
    protected override void CheckActions(int number)
    {


        if (number == 0)
        {
            soundPlayer.Play24Sound();
            playerCanvasController.SetCanvasText(textHolder.Text24);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if(number == 1)
        {
            playerCanvasController.EnableNextRepeatActionButton(false);
            playerCanvasController.SetCanvasText(textHolder.OpenDoorActionText);
            _openDoorController.EnableDoorsColliders();
        }
        else if(number == 2)
        {
            ShowRepeatButtonEvent?.Invoke();
            soundPlayer.Play28Sound();
            playerCanvasController.SetCanvasText(textHolder.Text28);
        }
        else if (number == 3)
        {
            ShowRepeatButtonEvent?.Invoke();
            soundPlayer.Play31Sound();
            playerCanvasController.SetCanvasText(textHolder.Text31);
        }
        else if (number == 4)
        {
            ShowRepeatButtonEvent?.Invoke();
            soundPlayer.Play202Sound();
            playerCanvasController.SetCanvasText(textHolder.Text202);
        }

    }
}