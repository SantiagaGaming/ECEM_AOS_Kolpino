using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossScenarioStep : ScenarioStep
{
    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            crossSoundPlayer.Play41Sound();
            playerCanvasController.SetCanvasText(crossTextHolder.Text41);
            StartCoroutine(WaitTillSoundEnds());
        }

        else if (number == 1)
        {
            crossSoundPlayer.Play43Sound();
            playerCanvasController.SetCanvasText(crossTextHolder.Text43);
            StartCoroutine(WaitTillSoundEnds());
        }

        else if(number == 2)
        {
            EndScenarioStepEvent?.Invoke();
            crossSoundPlayer.StopSoundPlayer();
        }
    }
}
