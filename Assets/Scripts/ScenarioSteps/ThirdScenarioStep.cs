using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdScenarioStep : ScenarioStep
{
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
    }
}