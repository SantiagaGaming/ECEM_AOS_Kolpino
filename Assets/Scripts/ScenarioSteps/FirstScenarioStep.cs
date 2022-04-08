using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScenarioStep : ScenarioStep
{
    
    public override void StartScenarioStep()
    {
        RepeatAction();
    }
    public override void StartNextAction()
    {
        base.StartNextAction();
        CheckActions(action);
    }
    public override void RepeatAction()
    {
        CheckActions(action);
    }
    private void CheckActions(int number)
    {
        if(number == 0)
        {
            soundPlayer.PlayBeginSound();
            playerCanvasController.SetCanvasText(textHolder.BeginText);
            StartCoroutine(WaitTillSoundEnds());
        }
        else if(number ==1)
        {
            soundPlayer.Play1Sound();
            playerCanvasController.SetCanvasText(textHolder.Text1);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 2)
        {
            soundPlayer.Play2Sound();
            playerCanvasController.SetCanvasText(textHolder.Text2);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 3)
        {
            soundPlayer.Play3Sound();
            playerCanvasController.SetCanvasText(textHolder.Text3);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 4)
        {
            soundPlayer.Play4Sound();
            playerCanvasController.SetCanvasText(textHolder.Text4);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 5)
        {
            soundPlayer.Play5Sound();
            playerCanvasController.SetCanvasText(textHolder.Text5);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 6)
        {
            soundPlayer.Play6Sound();
            playerCanvasController.SetCanvasText(textHolder.Text6);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 7)
        {
            soundPlayer.Play7Sound();
            playerCanvasController.SetCanvasText(textHolder.Text7);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if (number == 8)
        {
            soundPlayer.Play8Sound();
            playerCanvasController.SetCanvasText(textHolder.Text8);
            StartCoroutine(WaitTillSoundEnds());

        }
        else if(number == 9)
        {
            EndScenarioStepEvent();
        }

    }


}
