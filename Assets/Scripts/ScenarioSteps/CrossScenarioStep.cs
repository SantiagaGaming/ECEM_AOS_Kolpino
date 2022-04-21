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
            crossSoundPlayer.Play42Sound();
            playerCanvasController.SetCanvasText(crossTextHolder.Text42);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 2)
        {
            crossSoundPlayer.Play43Sound();
            playerCanvasController.SetCanvasText(crossTextHolder.Text43);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 3)
        {
            crossSoundPlayer.Play44Sound();
            playerCanvasController.SetCanvasText(crossTextHolder.Text44);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if (number == 4)
        {
            crossSoundPlayer.Play45Sound();
            playerCanvasController.SetCanvasText(crossTextHolder.Text45);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if(number == 5)
        {
            EndScenarioStepEvent?.Invoke();
            crossSoundPlayer.StopSoundPlayer();
        }
    }
}
